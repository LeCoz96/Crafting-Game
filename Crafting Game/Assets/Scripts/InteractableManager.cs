using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Interactable Data", menuName = "ScriptableObject/InteractableData")]
public class InteractableManager : ScriptableObject
{
    public struct Item 
    {
        public int Quantity;
        public Sprite Icon;
        public ItemType Type;
    }

    public enum ItemType
    {
        WOOD,
        CLOTH,
        TAPE
    }
}
