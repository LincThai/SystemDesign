using System;
using UnityEngine;

namespace SystemDesign.CraftingSystem
{
    [CreateAssetMenu(fileName = "New Potion", menuName = "Item/Potion", order = 0)]
    public class Potion : Item
    {
        [Header("Potions")]
        public Ingredient[] recipe = new Ingredient[0];
        public Effects effects;

        [Flags]
        public enum Effects
        {
            None = 0,
            RecoverHealth = 1,
            RecoverStamina = 2,
            CureStatusAilment = 4
        }
    }
}