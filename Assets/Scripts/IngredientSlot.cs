using UnityEngine;
using UnityEngine.UI;

namespace SystemDesign.CraftingSystem
{
    public class IngredientSlot : MonoBehaviour
    {
        // set variables
        // set variable to store the ingredient
        public Ingredient ingredient;
        // reference to the UI image
        public Image thumbnail;

        private void Awake()
        {
            // set the sprite for the slot to the sprite in the ingredient
            thumbnail.sprite = ingredient.thumbnail;
        }
    }
}