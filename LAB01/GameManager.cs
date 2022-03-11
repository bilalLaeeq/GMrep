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


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        //        player1Paddle.GetComponent<Paddle>().Reset();
        //       player2Paddle.GetComponent<Paddle>().Reset();
    }


    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
