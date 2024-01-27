using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController _controler;
    private Vector3 _playerVelocity;
    [SerializeField] private float _speed = 5.0f;

    private bool _isGrounded;
    [SerializeField] private float _gravity = -9.8f;
    [SerializeField] private float _jumpHeight = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        _controler = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _isGrounded = _controler.isGrounded;
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;

        _controler.Move(transform.TransformDirection(moveDirection) * _speed * Time.deltaTime);

        _playerVelocity.y += _gravity * Time.deltaTime;

        if (_isGrounded && _playerVelocity.y < 0.0f)
        {
            _playerVelocity.y = -2.0f;
        }

        _controler.Move(_playerVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        if (_isGrounded)
        {
            _playerVelocity.y = Mathf.Sqrt(_jumpHeight * -3.0f * _gravity);
        }
    }
}
