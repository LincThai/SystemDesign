using UnityEngine;
using UnityEngine.UI;

namespace SystemDesign.CraftingSystem
{
    public class IngredientSlot : MonoBehaviour
    {
        // set variable to store
        public Item ingredient;
        public Image thumbnail;

        private void Awake()
        {
            // set the sprite for the slot to the sprite in the ingredient
            thumbnail.sprite = ingredient.thumbnail;
        }
    }
}