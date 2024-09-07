using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SystemDesign.CraftingSystem
{
    [CreateAssetMenu(fileName = "New Ingredient", menuName = "Item/Ingredient", order = 0)]
    public class Ingredients : Items
    {
        [Header("Ingredients")]
        [TextArea(1, 10)]
        public string usageDescription;
    }
}