using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SystemDesign.CraftingSystem
{
    public class Items : ScriptableObject
    {
        [Header("Items")]
        public string Name;
        [TextArea(1, 10)]
        public string Description;
    }
}