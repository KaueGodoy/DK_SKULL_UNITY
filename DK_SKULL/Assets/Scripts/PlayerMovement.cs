using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] float speed = 5f;
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

        // jump
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpForce);
        }
    }


    private bool IsGrounded()
    {
        return Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
