using System.Collections.Generic;
using UnityEngine;

struct ItemStruct
{
    public int _quantity;
    public Sprite _icon;
}

public class PlayerInventory : MonoBehaviour
{
    private List<ItemStruct> _items = new List<ItemStruct>();

    public void AddItem(int quantity, Sprite icon)
    {
        ItemStruct item = new ItemStruct();

        item._quantity = quantity;
        item._icon = icon;

        _items.Add(item);
    }
}
