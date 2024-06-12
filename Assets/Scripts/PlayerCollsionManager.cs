using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollsionManager : MonoBehaviour
{

    PlayerMovement player;
    RaycastHit2D hit;
    [SerializeField] LayerMask obstacleMask;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<PlayerMovement>();
    }

    void OnCollisionEnter2D(Collision2D info)
    {
     /*   if (info.gameObject.tag == "Spikes")
        {
            switch (player.movingDir)
            {

            }
        } */
    }

}
