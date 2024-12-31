using System.Collections.Generic;
using UnityEngine;

public class InventoryBarManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _itemSlots;

    private int value = 0;

    public void UpdateInventory(Sprite icon, int quantity)
    {
        _itemSlots[value].GetComponent<InventoryBarItem>().UpdateIcon(icon);
        _itemSlots[value].GetComponent<InventoryBarItem>().UpdateCurrentQuantity(quantity);

        ++value;
    }
}
