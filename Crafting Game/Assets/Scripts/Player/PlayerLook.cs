using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    private Vector2 _look;
    [SerializeField] private float _lookSensitivity;

    [SerializeField] private PlayerInput _playerInput;
    private InputAction _lookActionX;
    private InputAction _lookActionY;

    private float _xRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        _playerInput = GetComponent<PlayerInput>();
        _lookActionX = _playerInput.actions.FindAction("MouseX");
        _lookActionY = _playerInput.actions.FindAction("MouseY");
    }

    void Update()
    {
        float MouseX = _lookActionX.ReadValue<float>() * _lookSensitivity * Time.deltaTime;
        float MouseY = _lookActionY.ReadValue<float>() * _lookSensitivity * Time.deltaTime;

        _xRotation -= MouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90.0f, 90.0f);

        transform.localRotation = Quaternion.Euler(_xRotation, 0.0f, 0.0f);
        transform.Rotate(Vector3.up * MouseX);
    }
}
