using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float Gravity = -19.62f;
    public float JumpHiegt = 3f;
    public Transform GroundCheck;
    public float GroundDistance = 0.4f;
    public LayerMask groundmask;
    Vector3 velocity;
    bool IsGRounded;
  

    void Update()
    {
        IsGRounded = Physics.CheckSphere(GroundCheck.position,GroundDistance,groundmask);
        if(IsGRounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x =Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move*speed*Time.deltaTime);
        if (Input.GetButtonDown("Jump") && IsGRounded)
        {
            velocity.y = Mathf.Sqrt(JumpHiegt * -2 * Gravity);
        }
        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
    }
    
}
