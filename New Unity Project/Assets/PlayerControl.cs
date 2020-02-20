using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 100.0f;
    public float JunmpPower = 700.0f;
    Rigidbody2D rigidbody2d;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        Vector2 Position = transform.position;
       // float x = Input.GetAxis("Horizontal");
        
        if (Input.GetKey(KeyCode.D))
        {
            Position.x += speed;
            //rigidbody2d.AddForce(transform.right * speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Position.x -= speed;
            //rigidbody2d.AddForce(transform.right * -speed);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.AddForce(transform.up *JunmpPower);
        }
        transform.position = Position;
    }
}
