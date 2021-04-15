using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldiermovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 8f;
    float gravity = -19.62f;
    Vector3 velocity; 
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public float jumpheight = 5f;
    public Animator soldieranim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    isGrounded = Physics.CheckSphere(groundCheck.position , groundDistance , groundMask);
    if(isGrounded && velocity.y < 0)
    {
        velocity.y = -2f;
    }
     float xdir = Input.GetAxis("Horizontal");
     float zdir = Input.GetAxis("Vertical");
    Vector3 move = transform.right * xdir + transform.forward * zdir;
    controller.Move(move * speed * Time.deltaTime);
    if(Input.GetButtonDown("Jump") && isGrounded)
    {
    velocity.y += Mathf.Sqrt(jumpheight * -2f * gravity);
    }
    velocity.y += gravity * Time.deltaTime;
    controller.Move(velocity * Time.deltaTime);
    /*
    if(Input.GetKeyDown(KeyCode.UpArrow))
    {
        soldieranim.SetBool("isRunning" , true);
    }
    if(Input.GetKeyUp(KeyCode.UpArrow))
    {
        soldieranim.SetBool("isRunning" , false);
    }
    if(Input.GetKeyDown(KeyCode.DownArrow))
    {
        soldieranim.SetBool("isWalkingBack" , true);
    }
    if(Input.GetKeyUp(KeyCode.DownArrow))
    {
        soldieranim.SetBool("isWalkingBack" , false);
    }
    if(Input.GetKeyDown(KeyCode.Space))
    {
        soldieranim.SetBool("isJumping" , true);
    }
    if(Input.GetKeyUp(KeyCode.Space))
    {
        soldieranim.SetBool("isJumping" , false);
    }
    if(Input.GetKeyDown(KeyCode.Mouse0))
    {
        soldieranim.SetBool("isShooting" , true);
    }
    if(Input.GetKeyUp(KeyCode.UpArrow))
    {
        soldieranim.SetBool("isShooting" , false);
    }*/
    }
}
