using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    [SerializeField] private float _distance;

    [SerializeField] private LayerMask _layerMask;

    private PlayerUI _playerUI;
    private InputManager _inputManager;
    private PlayerInventory _playerInventory;

    void Start()
    {
        _playerUI = GetComponent<PlayerUI>();
        _inputManager = GetComponent<InputManager>();
        _playerInventory = GetComponent<PlayerInventory>();
    }

    void Update()
    {
        _playerUI.UpdateMessage(string.Empty);

        Ray ray = new Ray(_camera.transform.position, _camera.transform.forward);
        //Debug.DrawRay(ray.origin, ray.direction * _distance);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, _distance, _layerMask))
        {
            if(hit.collider.GetComponent<InteractionManager>() != null)
            {
                InteractionManager interactable = hit.collider.GetComponent<InteractionManager>();

                _playerUI.UpdateMessage(interactable.GetMessage());

                if (_inputManager._onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();

                    _playerUI.UpdateInventory(interactable.GetIcon(), interactable.GetQuantity());

                    _playerInventory.AddItem(interactable.GetQuantity(), interactable.GetIcon());
                }
            }
        }
    }
}
