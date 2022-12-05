using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{

    Rigidbody rb;
    float dirX;
    float moveSpeed = 20f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        dirX = Input.acceleration.x * moveSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);
    }
}

