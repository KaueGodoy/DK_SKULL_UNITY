using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "HitStomp")
        {
            Die();
        }

    }

    public void Die()
    {
        Destroy(gameObject);

        // loot 
    }
}
