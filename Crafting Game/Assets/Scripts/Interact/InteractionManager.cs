using UnityEngine;

public enum ItemType
{
    WOOD,
    CLOTH,
    TAPE
}

public abstract class InteractionManager : MonoBehaviour
{
    [SerializeField] private string _message;
    [SerializeField] private int _quantity;
    [SerializeField] private Sprite _icon;
    public ItemType Type;

    public string GetMessage() { return _message; }
    public int GetQuantity() { return _quantity; }
    public Sprite GetIcon() { return _icon; }

    public void BaseInteract() 
    {
        Interact();
    }

    protected virtual void Interact() { }

}
