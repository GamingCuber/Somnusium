using System;
using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public Collider2D playerCollider;
    public float speedrate = 0.01f;
    public UnityEngine.Vector2 movementVector;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");


    }
    void FixedUpdate()
    {
        if (movementVector.magnitude > 1)
        {
            movementVector = movementVector.normalized;
        }

        playerBody.MovePosition(transform.position + (UnityEngine.Vector3) movementVector * speedrate);
    }


}
