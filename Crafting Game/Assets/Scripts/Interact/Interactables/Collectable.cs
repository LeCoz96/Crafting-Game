public class Collectable : InteractionManager
{
    protected override void Interact()
    {
        gameObject.SetActive(false);
    }
}
