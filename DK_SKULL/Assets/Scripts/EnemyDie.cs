using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    public Rigidbody2D rb;
    public float bounce;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "HitStomp")
        {
            Bounce();
            Die();
        }

    }

    public void Bounce()
    {   // player upwards bounce
        rb.velocity = new Vector2(rb.velocity.x, bounce);
    }

    public void Die()
    {   // spawn loot
        GetComponent<LootBag>().InstantiateLoot(transform.position);
        // kill enemy
        Destroy(gameObject);

        
    }
}
