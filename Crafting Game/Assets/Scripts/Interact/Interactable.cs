using UnityEngine;

public class Interactable : MonoBehaviour
{
    public enum ItemType
    {
        WOOD,
        CLOTH,
        TAPE
    }

    [SerializeField] protected string _message;
    [SerializeField] protected int _quantity;
    [SerializeField] protected Sprite _icon;
    public ItemType Type;

    public string GetMessage() { return _message; }
    public int GetQuantity() { return _quantity; }
    public Sprite GetIcon() { return _icon; }

    public void Interact()
    {
        gameObject.SetActive(false);
    }
}
