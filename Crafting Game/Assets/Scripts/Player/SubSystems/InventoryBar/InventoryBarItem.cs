using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryBarItem : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TextMeshProUGUI _quantity;

    private int _currentQuantity = 0;

    public void UpdateCurrentQuantity(int value)
    {
        _quantity.text = (_currentQuantity += value).ToString();
    }

    public void UpdateIcon(Sprite icon)
    {
        _icon.sprite = icon;
    }
}
