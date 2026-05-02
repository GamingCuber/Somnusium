using System;
using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public Collider2D playerCollider;
    public float speedrate = 0.01f;
    public UnityEngine.Vector2 movementVector;
    public AudioSource audioSource;
    public Animator playerAnimator;
    void Start()
    {
        audioSource.volume = 0;
    } 

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");
        if (movementVector.x == 0 && movementVector.y == 0)
        {
            playerAnimator.SetBool("Idle", true);
            playerAnimator.SetBool("Run", false);
        } else
        {
            playerAnimator.SetBool("Idle", false);
            playerAnimator.SetBool("Run", true);
        }
    }
    void FixedUpdate()
    {
        if (movementVector.magnitude > 1)
        {
            movementVector = movementVector.normalized;
        }
        if (movementVector.x == 0 && movementVector.y == 0)
        {
            audioSource.volume = 0;
        } else
        {
            audioSource.volume = 0.5f;
        }

        playerBody.MovePosition(transform.position + (UnityEngine.Vector3) movementVector * speedrate);
    }


}
