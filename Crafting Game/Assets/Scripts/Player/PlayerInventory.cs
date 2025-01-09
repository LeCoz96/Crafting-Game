using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private PlayerUI _playerUI;
    private List<InteractableManager.Item> _items/* = new List<InteractableManager.ItemType>()*/;

    [SerializeField] private string _cannotCollectText;
    [SerializeField] private InteractableManager _interactionManager;

    void Start()
    {
        _playerUI = GetComponent<PlayerUI>();
    }

    public string GetCannotCollectText() { return _cannotCollectText; }

    public bool CanCollectItem() // needs to be sorted out
    {
        return true;
    }

    public void AddItem(Sprite icon, int quantity, InteractableManager.ItemType type)
    {
        InteractableManager.Item item = new InteractableManager.Item();

        item.Quantity = quantity;
        item.Icon = icon;
        item.Type = type;

        //_playerUI.UpdateInventory(item._icon, item._quantity);
        _items.Add(item);
    }
}
