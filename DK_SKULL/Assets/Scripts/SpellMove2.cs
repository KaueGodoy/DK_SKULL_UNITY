using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellMove2 : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private float speed = 0f;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(new Vector2(20 * Time.deltaTime * speed, 20 * Time.deltaTime * speed));
    }

    void Update()
    {

    }
}
