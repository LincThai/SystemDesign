using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        public CraftingSlot resultsSlot;
        // reference to item that is clicked and dragged
        private Items currentItem;
        
        // list of given ingredients in the slots
        public List<Items> ingredients;
        // list of results (Potions). This also contains the recipe in the scriptable object
        public List<Potions> potions;

        public void Update()
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                if (currentItem != null)
                {
                    
                }
            }
        }

        public void CheckCompletedRecipes()
        {
            // system.linq
            foreach (Potions potion in potions)
            {
                for (int i = 0; i < potion.recipe.Length; i++)
                {
                    int index = 0;
                    if (potion.recipe[i] == craftingSlots[index].item)
                    {
                    }
                    else 
                    { index++; }
                }
            }
        }
    }
}