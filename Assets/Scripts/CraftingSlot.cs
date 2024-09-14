using UnityEngine;
using UnityEngine.UI;

namespace SystemDesign.CraftingSystem
{
    public class CraftingSlot : MonoBehaviour
    {
        // set variables
        // the item
        public Ingredient item;
        // slot number
        public int slotIndex;
        // the thumbnail
        public Image thumbnail;
    }
}