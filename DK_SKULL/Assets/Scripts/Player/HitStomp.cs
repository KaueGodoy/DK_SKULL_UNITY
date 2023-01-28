using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStomp : MonoBehaviour
{
    public float bounce;
    public Rigidbody2D rb;
    EnemyDie enemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "HeadHitBox")
        {
           
            rb.velocity = new Vector2(rb.velocity.x, bounce);
        }
    }
}
