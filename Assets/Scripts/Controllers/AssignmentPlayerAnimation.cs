using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentPlayerAnimation : MonoBehaviour
{
    PlayerInputController controller;

    [SerializeField] private Animator anim;

    private void Awake()
    {
        controller = GetComponent<PlayerInputController>();
    }    
    void Start()
    {
        controller.OnMoveEvent += AnimState;
    }
    void AnimState(Vector2 dir)
    {
        anim.SetBool("Run", dir.magnitude > 0);
    }
}
