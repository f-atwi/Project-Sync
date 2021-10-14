using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform body;
    public float sensitivity = 100f;
    private float angle = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float movement_horizontal = Input.GetAxis("Mouse X")*sensitivity*Time.deltaTime;
        float movement_vertical = -Input.GetAxis("Mouse Y")*sensitivity*Time.deltaTime;
        angle += movement_vertical;
        angle = Mathf.Clamp(angle, -90f, 90f);
        body.Rotate(Vector3.up * movement_horizontal);

        transform.localRotation = Quaternion.Euler(angle,0f,0f);
    }
}
