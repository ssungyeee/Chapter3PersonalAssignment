using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class AssignmentAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private AssignmentCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<AssignmentCharacterController>();        
    }

    void Start()
    {
        _controller.OnLookEvent += OnaAim;
    }

    public void OnaAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {        
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        armRenderer.flipY = Mathf.Abs(rotZ) > 90f;
        characterRenderer.flipX = armRenderer.flipY;

        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}