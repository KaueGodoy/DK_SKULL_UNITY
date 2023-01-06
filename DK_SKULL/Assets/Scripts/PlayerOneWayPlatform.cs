using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneWayPlatform : MonoBehaviour
{
    private GameObject currentOneWayPlatform;

    [SerializeField] private BoxCollider2D playerCollider;
    [SerializeField] private float collisionDisableTime = 0.5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if(currentOneWayPlatform != null)
            {
                StartCoroutine(DisableCollision());
            }
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("OneWayPlatform"))
        {
            currentOneWayPlatform = collision.gameObject;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("OneWayPlatform"))
        {
            currentOneWayPlatform = null;
        }
    }

    private IEnumerator DisableCollision()
    {
        BoxCollider2D platformCollider = currentOneWayPlatform.GetComponent<BoxCollider2D>();
        PlatformEffector2D platformOneWay = currentOneWayPlatform.GetComponent<PlatformEffector2D>();

        //Physics2D.IgnoreCollision(playerCollider, platformCollider);
        platformOneWay.rotationalOffset = 180;
        yield return new WaitForSeconds(collisionDisableTime);
        platformOneWay.rotationalOffset = 0;
        //Physics2D.IgnoreCollision(playerCollider, platformCollider, false);

    }

    // Physics2D ignores collision with the current platform (GAME OBJECT)
    // rotationalOffset changes the offset of the one way effect from Unity making the player fall off (TILEMAP)

}
