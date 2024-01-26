using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _playerMovementSpeed;

    private PlayerInput _playerInput;
    private InputAction _moveAction;

    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions.FindAction("Move");
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector2 Direction = _moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(Direction.x, 0.0f, Direction.y) * _playerMovementSpeed * Time.deltaTime;
    }
}
