using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public bool enableInput = false;
   // bool crouch = false;
	
    // Update is called once per frame
    void Update () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if(controller.m_Grounded)
        _animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump") && enableInput)
        {
            jump = true;
            _animator.SetTrigger("jump");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _animator.SetTrigger("attack");
        }


    }

    void FixedUpdate ()
    {
        // Move our character
        if (enableInput)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;
        }

      
    }

    public void EnableInput()
    {
        enableInput = true;
    }

    public void DisableInput()
    {
        enableInput = false;
    }
}
