using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryBarManager : MonoBehaviour
{
    [SerializeField] private GameObject _item;

    public void UpdateInventory(Sprite icon, int quantity)
    {
        _item.GetComponent<InventoryBarItem>().UpdateIcon(icon);
        _item.GetComponent<InventoryBarItem>().UpdateCurrentQuantity(quantity);
    }
}
