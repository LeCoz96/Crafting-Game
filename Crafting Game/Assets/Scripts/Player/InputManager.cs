using UnityEngine;

public class InputManager : MonoBehaviour
{
    public InputManager inputManager;

    private void Awake()
    {
        inputManager = new InputManager();
    }

    private void OnEnable()
    {
        inputManager.enabled = true;
    }

    private void OnDisable()
    {
        inputManager.enabled = false;
    }
}
