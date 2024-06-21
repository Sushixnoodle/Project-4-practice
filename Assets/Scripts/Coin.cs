using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Reference to the game manager to update the score
    public GameManager gameManager;

    void Start()
    {
        // Find the GameManager in the scene (assuming there's only one)
        if (gameManager == null)
        {
            gameManager = GameObject.FindObjectOfType<GameManager>();
        }
    }

    // When something enters the trigger collider
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to the player
        if (other.CompareTag("Player"))
        {
            // Increase the score
            gameManager.IncreaseScore();

            // Destroy the coin
            Destroy(gameObject);
        }
    }
}