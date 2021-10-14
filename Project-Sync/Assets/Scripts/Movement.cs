using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public CharacterController controller;
    public float speed = 5f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 translate = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        controller.Move(translate * speed * Time.deltaTime);

        

    }
}
