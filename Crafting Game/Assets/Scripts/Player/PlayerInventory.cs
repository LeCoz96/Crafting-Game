using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private struct ItemStruct
    {
        public Sprite _icon;
        public int _quantity;
    }
    private PlayerUI _playerUI;
    private List<ItemStruct> _items = new List<ItemStruct>();

    void Start()
    {
        _playerUI = GetComponent<PlayerUI>();
    }

    public void AddItem(Sprite icon, int quantity)
    {
        ItemStruct item = new ItemStruct();

        item._icon = icon;
        item._quantity = quantity;

        _playerUI.UpdateInventory(item._icon, item._quantity);
        _items.Add(item);
    }
}
