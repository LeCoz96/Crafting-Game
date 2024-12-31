using UnityEngine;

enum ItemType
{
    WOOD,
    CLOTH
}

public class Collectable : InteractionManager
{
    [SerializeField] private ItemType _type;

    protected override void Interact()
    {
        gameObject.SetActive(false);
    }
}
