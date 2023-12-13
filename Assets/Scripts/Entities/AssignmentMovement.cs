using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentMovement : MonoBehaviour
{
    private AssignmentCharacterController _controller;
    private CharacterStatsHandler _stats;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    

    private void Awake()
    {
        _controller = GetComponent<AssignmentCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _stats = GetComponent<CharacterStatsHandler>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * _stats.CurrentStats.speed;
        _rigidbody.velocity = direction;
    }    
}
