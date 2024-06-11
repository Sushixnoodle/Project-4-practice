using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
   enum direction
    {
        North, South, East, West
    }

    public float speed;
    Rigidbody2D rb;
    direction movingDir;

     
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;

            if (Input.GetAxisRaw("Horizontal")  > 0)
            {
                movingDir = direction.East;
            }
            else if (true)
            {
                movingDir = direction.West;
            } 
        }
        else if (Input.GetAxisRaw("Vertical") != 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;

            if (Input.GetAxisRaw("Vertical") > 0)
            {
                movingDir = direction.North;
            }
            else if (true)
            {
                movingDir = direction.South;
            }
        }
    }

    private void FixedUpdate()
    {
        switch(movingDir)
        {
            case direction.North:
                rb.velocity = new Vector2(0, speed * Time.fixedDeltaTime);
                break;
            case direction.South:
                rb.velocity = new Vector2(0, -speed * Time.fixedDeltaTime);
                break;
            case direction.East:
                rb.velocity = new Vector2(speed * Time.fixedDeltaTime, 0);
                break;
            case direction.West:
                rb.velocity = new Vector2(-speed * Time.fixedDeltaTime, 0);
                break;


        }
    }
}
