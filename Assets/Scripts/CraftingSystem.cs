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
        
        // list of given ingredients in the slots
        public List<Items> ingredients;
        // list of results (Potions). This also contains the recipe in the scriptable object
        public List<Items> potions;
    }
}