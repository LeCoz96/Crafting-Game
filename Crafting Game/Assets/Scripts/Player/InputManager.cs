using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerInput.OnFootActions _onFoot;

    private PlayerMotor _motor;

    void Awake()
    {
        _playerInput = new PlayerInput();
        _onFoot = _playerInput.OnFoot;

        _motor = GetComponent<PlayerMotor>();
        _onFoot.Jump.performed += ctx => _motor.Jump();
    }

    void FixedUpdate()
    {
        _motor.ProcessMove(_onFoot.Movement.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        _onFoot.Enable();
    }

    private void OnDisable()
    {
        _onFoot.Disable();
    }
}
