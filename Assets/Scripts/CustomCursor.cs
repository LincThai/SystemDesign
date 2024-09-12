using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SystemDesign.CraftingSystem
{
    public class CustomCursor : MonoBehaviour
    {
        private void Awake()
        {
            // follow mouse position
            transform.position = Input.mousePosition;
        }

        private void Update()
        {
            // follow mouse position
            transform.position = Input.mousePosition;
        }
    }
}