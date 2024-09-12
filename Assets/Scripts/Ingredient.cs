using UnityEngine;

namespace SystemDesign.CraftingSystem
{
    [CreateAssetMenu(fileName = "New Ingredient", menuName = "Item/Ingredient", order = 0)]
    public class Ingredient : Item
    {
        [Header("Ingredients")]
        [TextArea(1, 10)]
        public string usageDescription;
    }
}