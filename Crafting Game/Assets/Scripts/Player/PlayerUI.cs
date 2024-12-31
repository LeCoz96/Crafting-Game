using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private InventoryBarManager _inventoryBarManager;

    public void UpdateMessage(string message)
    {
        _text.text = message;
    }

    public void UpdateInventory(Sprite icon, int quantity)
    {
        _inventoryBarManager.UpdateInventory(icon, quantity);
    }
}
