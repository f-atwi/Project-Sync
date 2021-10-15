using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public CharacterController controller;
    public float speed = 5f;
    public float gravity = -9.81f;
    Vector3 velocity;
    public float jumpheight;


    // Update is called once per frame
    void Update()
    {
        Vector3 translate;


        // Reseting velocity when touching the ground
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // Check if jumping and compute upward force
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y += Mathf.Sqrt(-2f * gravity * jumpheight);
        }
        velocity.y += gravity * Time.deltaTime;

        // Calculate movement according to input if grounded
        if (controller.isGrounded)
        {
            translate = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
            translate *= speed;

        }
        // Maintain horizontal speed when in air
        else
        {
            translate = controller.velocity;
            translate.y = 0;
            
        }

        // Excute the move
        translate.y = velocity.y;
        controller.Move(translate *  Time.deltaTime);
        

    }
}
