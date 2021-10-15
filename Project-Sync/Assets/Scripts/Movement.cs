using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public CharacterController controller;
    public Transform groundCheck;
    public float groundDistance= 0.1f;
    public LayerMask groundMask;
    public float speed = 5f;
    public float gravity = -9.81f;
    public Vector3 velocity;
    public float jumpheight;
    public float movement;
    Vector3 plane = new Vector3(1f, 0f, 1f);
    public Vector3 test;
    public bool test2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y += Mathf.Sqrt(-2f * gravity * jumpheight);
        }
        Vector3 translate = Vector3.zero;
        velocity.y += gravity * Time.deltaTime;
        test = controller.velocity;
        if (controller.isGrounded)
        {
            translate = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
            translate *= speed;

        }
        else
        {
            translate = controller.velocity;
            translate.y = 0;
            
        }
        translate.y = velocity.y;
        controller.Move(translate *  Time.deltaTime);
        test2 = controller.isGrounded;
        

    }
}
