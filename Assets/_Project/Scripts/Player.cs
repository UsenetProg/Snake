using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody body;

    public float speed;

    private void Update()
    {
    }
    public void SnakeSpeed()
    {
        body.velocity = new Vector3(0, 0, speed);
    }
    public void PlayerTail()
    {
        body = Instantiate(body, transform);
        body.transform.position = CalculateTailPosition();
    }

    private Vector3 CalculateTailPosition()
    {
        return new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
}
