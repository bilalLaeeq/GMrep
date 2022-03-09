using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddle : MonoBehaviour
{
          //The variable
        private Rigidbody2D rigidBody;

        //This function is called once in the beginning of object creation.
        
        private void Awake()
        {
            rigidBody = GetComponent<Rigidbody2D>();
        }

          private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
                direction = Vector2.up;
            else if (Input.GetKey(KeyCode.DownArrow))
                direction = Vector2.down;
            else
                direction = Vector2.zero;
    }
     public float speed = 7.0f;
        // Called at some fixed periodic intervals
        void FixedUpdate()
        {
            if(direction.sqrMagnitude!=0)
                rigidBody.AddForce(direction * this.speed);
        }
}
