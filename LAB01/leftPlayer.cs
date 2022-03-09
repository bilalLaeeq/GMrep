using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftPlayer : MonoBehaviour
{
       //The variable
        private Rigidbody2D rigidBody;

        //This function is called once in the beginning of object creation.
        
        private void Awake()
        {
            rigidBody = GetComponent<Rigidbody2D>();
        }
        private Vector2 direction;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.S))
                direction = Vector2.down;
            else if (Input.GetKey(KeyCode.W))
                direction = Vector2.up;
            else
                direction = Vector2.zero;
        }
        public float speed = 9.0f;
        // Called at some fixed periodic intervals
        void FixedUpdate()
        {
            if(direction.sqrMagnitude!=0)
                rigidBody.AddForce(direction * this.speed);
        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
