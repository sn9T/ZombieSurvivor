using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMover : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private PlayerInput _input;
    private float _speed = 5;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        _input = new PlayerInput();
        _input.Enable();
    }

    private void Update()
    {
        Vector2 direction = _input.Movement.Move.ReadValue<Vector2>();
        _rigidbody.velocity = direction * _speed;
    }
}
