using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private InteractableManager _interactManager;
    [SerializeField] private InteractableManager.Item _type;
    [SerializeField] private string _message;
    //[SerializeField] protected int _quantity;
    //[SerializeField] protected Sprite _icon;

    void Start()
    {
        // GET THE ITEMS FROM THE STRUCT
    }

    public string GetMessage() { return _message; }
    //public int GetQuantity() { return _interactManager.Quantity; }
    //public Sprite GetIcon() { return _interactManager.Icon; }
    //public InteractableManager.ItemType GetItemType() { return _type; }

    public void Interact()
    {
        Debug.Log(gameObject.name + " collected");
        //gameObject.SetActive(false);
    }
}
