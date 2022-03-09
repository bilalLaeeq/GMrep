using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    protected KeyCode UpKey { get; set; }
    protected KeyCode DownKey { get; set; }
    public float Speed { get; set; } = 5.0f;
    protected Rigidbody2D control { get; set; }

    protected void UpdatePositions()
    {
        float position = 0.0f;

        if (Input.GetKey(UpKey))
            position = Speed;
        else if (Input.GetKey(DownKey))
            position = -Speed;
        if (Input.GetKey(KeyCode.W))
            position = Speed;
        else if (Input.GetKey(KeyCode.S))
            position = -Speed;

        control.velocity = new Vector2(control.velocity.x, position);
    }
}