

using System.Text.RegularExpressions;
using System;
using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldiermovement : MonoBehaviour
{ 
    public Animator animator;
    public CharacterController controller;
    float speed;
    Vector3 velocity;
    float jump = 3f;
    public float gravity = -9.81f;
    bool isGrounded;
    public Transform groundCheck;
    float groundDistance = 0.4f;
    public LayerMask groundMask;
    // Update is called once per frame
    void Start(){
    animator = GetComponent<Animator>();

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) ){
            animator.SetBool("iswalking" , true);
            
        }
       
        if(Input.GetKeyUp(KeyCode.UpArrow) ){
            animator.SetBool("iswalking" , false);
           
        }
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            animator.SetBool("isshooting" , true);
        }
        if(Input.GetKeyUp(KeyCode.Mouse0)){
            animator.SetBool("isshooting" , false);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            animator.SetBool("iswalkingback" , true);
            speed = 4f;
            
        }
         if(Input.GetKeyUp(KeyCode.DownArrow)){
            animator.SetBool("iswalkingback" , false);
            
        }/*
        if(Input.GetButtonDown("Jump")){
            animator.SetBool("isjumping" , true);
        }
          if(Input.GetButtonUp("Jump")){
            animator.SetBool("isjumping" , false);
        }*/
if(Input.GetKey(KeyCode.Space)){
            animator.SetBool("isjumping" , true);
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            animator.SetBool("isjumping" , false);
        }

       
        isGrounded = Physics.CheckSphere(groundCheck.position , groundDistance , groundMask);
        if(isGrounded && velocity.y < 0){
           velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
          
    Vector3 move = transform.right * x + transform.forward * y;
    controller.Move(move * speed * Time.deltaTime);

       if(Input.GetButton("Jump") && isGrounded){
           animator.SetBool("isjumping" , true);
        velocity.y = Mathf.Sqrt(jump * -2f * gravity);
     
    }
   
    velocity.y += gravity*Time.deltaTime;
    controller.Move(velocity * Time.deltaTime);

    }
}
