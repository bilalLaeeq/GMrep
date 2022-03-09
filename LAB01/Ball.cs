//bilal laeeq  61504


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D ball;
    float initialSpeed = 200.0f;
    float ballSpeedIncrement = 2.0f;
    float paddleSpeedIncrement = 1.0f;

    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        ball.AddForce(new Vector2(4.0f, -4.0f) * initialSpeed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("GameManager"))
        {
            ball.velocity = ball.velocity * ballSpeedIncrement;
            increasePaddleSpeed();
        }
    }

    void increasePaddleSpeed()
    {
        foreach (var obj in GameObject.FindGameObjectsWithTag("GameManager"))
        {
            var manager = obj.GetComponent<GameManager>();
            manager.Speed += paddleSpeedIncrement;
        }
    }
}
