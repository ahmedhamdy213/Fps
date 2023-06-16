using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_louck : MonoBehaviour
{
    public float Sensetvity = 100f;
    public Transform PlayerBody;
    float xRotation = 0f;
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")* Sensetvity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")* Sensetvity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation =Mathf.Clamp(xRotation, -90f, 90f);
        transform .localRotation= Quaternion.Euler(xRotation,0f,0f);
        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}
