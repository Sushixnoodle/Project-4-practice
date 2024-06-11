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
   // Direction movingDir;

    // Start is called before the first frame update
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

         /*   if (Input.GetAxisRaw("Horizontal") ! > 0)
            {
                movingDir = Direction.East;
            }
            else if (true)
            {
                movingDir = Direction.West;
            } */
        }
        else if (Input.GetAxisRaw("Vertical") != 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
    }
}
