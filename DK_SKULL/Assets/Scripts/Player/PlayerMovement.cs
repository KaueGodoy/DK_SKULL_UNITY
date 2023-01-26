using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] public float speed = 5f;

    // jump
    [Range(1f, 10f)]
    [SerializeField] float jumpForce = 5f;

    private float movementX = 0f;

    [SerializeField] private LayerMask jumpableGround;
    private BoxCollider2D boxCollider;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        // horizontal movement 
        movementX = Input.GetAxisRaw("Horizontal");
        rigidbody.velocity = new Vector2(movementX * speed, rigidbody.velocity.y);

        //jump
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rigidbody.velocity = Vector2.up * jumpForce;
        }

        // adjustable jump height 
       /* if (Input.GetKeyUp(KeyCode.Space) && IsGrounded() && rigidbody.velocity.y > 0)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpForce / 2);
        }
       */
    }


    private bool IsGrounded()
    {
        return Physics2D.BoxCast(boxCollider.bounds.min, boxCollider.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
