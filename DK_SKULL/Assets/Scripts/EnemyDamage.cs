using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // apply enemy damage
            var healthComponent = collision.GetComponent<PlayerHealth>();
            if (healthComponent != null)
            {
                healthComponent.TakeDamage(1);
            }

            // decreases current health from the array by 1
            var heartComponent = collision.GetComponent<HeartHealth>();
            if (heartComponent != null)
            {
                heartComponent.health--;
            }
        }

    }

}
