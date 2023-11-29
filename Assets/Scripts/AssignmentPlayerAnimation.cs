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
    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += AnimState;
    }

    void AnimState(Vector2 dir)
    {
        anim.SetBool("Run", dir.magnitude > 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
