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



using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ball : MonoBehaviour
{
public float speed;
public Rigidbody2D rb;
public Vector3 startPosition;

    private float x;
    private float y;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    private void Launch()
    {
        //   float x = Random.Range(0, 2) == 0 ? -1 : 1;

        if (Random.Range(0, 2) == 0)
        {
            x = -1;
        }
        else
        {
            x = 1;
        }

        if (Random.Range(0, 2) == 0)
        {
            y = -1;
        }
        else
        {
            y = 1;
        }

        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }
}

