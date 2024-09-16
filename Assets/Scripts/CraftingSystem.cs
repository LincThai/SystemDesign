using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SystemDesign.CraftingSystem
{
    public class CraftingSystem : MonoBehaviour
    {
        // set variables
        // UI variables
        [Header("UI Variables")]
        // Array for crafting slots (UI)
        public CraftingSlot[] craftingSlots;
        // results slot
        public ResultsSlot resultsSlot;
        // reference to item that is clicked and dragged
        private Ingredient currentItem;
        // Custom Cursor
        public Image customCursor;

        // list of given ingredients in the slots
        public List<Ingredient> ingredients;
        // list of results (Potions). This also contains the recipe array in the scriptable object
        public List<Potion> potions;

        // bool to tell the crafting slots gto reducee matchs by 1
        public bool slotIsCleared = false;

        public void Update()
        {
            // check for mouse input release of left click
            if (Input.GetMouseButtonUp(0)) 
            {
                // call on release function
                OnRelease();
            }
        }

        public void CheckCompletedRecipes()
        {
            // set variable for the outcome of this check 
            // this is the result that is the output
            Item outcome = null;

            // for each potion in the postions list
            foreach (Potion potion in potions)
            {
                // int variable to check the number of matching ingredients
                int matchs = 0;
                // assign the recipe list to a local list
                List<Ingredient> recipe = potion.recipe;

                // for every item in this array
                for (int i = 0; i < recipe.Count; i++)
                {
                    // check if the order of the recipe in the array is the same in the crafting slots
                    if (recipe[i] == ingredients[i])
                    {
                        // increase the number of matchs
                        matchs++;
                        Debug.Log(matchs);
                        // check if it goes iver the maximum
                        if (matchs > craftingSlots.Length)
                        {
                            matchs = craftingSlots.Length;
                        }
                    }
                    else
                    {
                        // go back to the start of this loop
                        return;
                    }
                }

                // check if player has just cleared a slot
                if (slotIsCleared)
                {
                    // reduce matches
                    matchs--;
                    Debug.Log("matchs reduced");
                    // reset bool
                    slotIsCleared = false;
                }

                // check if the number of matches is equal to the number of slots
                // this means that the recipe is the same as whats in the crafting slots
                if (matchs == craftingSlots.Length)
                {
                    Debug.Log("Recipe Found");
                    // assign potion to outcome
                    outcome = potion;
                }
                else
                {
                    Debug.Log("No Recipe Found");
                    // outcome becomes null
                    outcome = null;
                }
                
                // place item (outcome) into the results slot
                resultsSlot.item = outcome;
                if (outcome != null)
                {
                    // show image of outcome
                    resultsSlot.thumbnail.sprite = outcome.thumbnail;
                }
                else { resultsSlot.thumbnail.sprite = null; }
            }
        }

        public void OnMouseDownItem(IngredientSlot ingredientSlot)
        {
            // check if current item is null
            if (currentItem == null)
            {
                // assign value of current item
                currentItem = ingredientSlot.ingredient;
                // turn on custom cursor and assign the sprite to the icon of the item
                customCursor.gameObject.SetActive(true);
                customCursor.sprite = currentItem.thumbnail;
            }
        }

        // function to clear a slot with a click
        public void OnClickSlot(CraftingSlot slot)
        {
            // set the item in the slot to null
            slot.item = null;
            // current thumbnail set to null
            slot.thumbnail.sprite = null;
            // set the ingredient in the slot to null in the list
            ingredients[slot.slotIndex] = null;
            // set bool to true
            slotIsCleared = true;

            // call function to check for completed recipes
            CheckCompletedRecipes();
        }

        public void OnRelease()
        {
            if (currentItem != null)
            {
                // disable custom cursor
                customCursor.gameObject.SetActive(false);
                // set a crafting slot variable for the nearest slot and a float variable for distance
                CraftingSlot nearestSlot = null;
                float shortestDistance = float.MaxValue;

                // loop to find the nearest slot in the crafting slots array
                foreach (CraftingSlot slot in craftingSlots)
                {
                    // calculate the distance between the mouse and slot then store it in float variable called dist
                    float dist = Vector2.Distance(Input.mousePosition, slot.transform.position);
                    // check if dist is less that the shortestDistance 
                    if (dist < shortestDistance)
                    {
                        // shortestDistance is now set to dist
                        shortestDistance = dist;
                        // nearestSlot is set to the Slot we just checked in the loop
                        nearestSlot = slot;
                    }
                }
                // override the thumbnail sprite with the thumbnail in the item
                nearestSlot.thumbnail.sprite = currentItem.thumbnail;
                // set the item in the nearestSlot to the currentItem
                nearestSlot.item = currentItem;
                // add item to ingredient list
                ingredients[nearestSlot.slotIndex] = currentItem;
                // set the current item to null meaning there is nothing there
                currentItem = null;

                // call function to check for the completed recipes
                CheckCompletedRecipes();
            }
        }
    }
}