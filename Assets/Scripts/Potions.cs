using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SystemDesign.CraftingSystem
{
    [CreateAssetMenu(fileName = "New Potion", menuName = "Item/Potion", order = 0)]
    public class Potions : Items
    {
        [Header("Potions")]
        public Ingredients[] recipes = new Ingredients[0];
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