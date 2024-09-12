using UnityEngine;

namespace SystemDesign.CraftingSystem
{
    public class Item : ScriptableObject
    {
        [Header("Items")]
        public string Name;
        [TextArea(1, 10)]
        public string Description;
        public Sprite thumbnail;
    }
}