using UnityEngine;

public class CollisionBoolActivator : MonoBehaviour
{
    // Reference to the UI panel to be enabled
    public GameObject panel;

    // Tag of the player object
    public string playerTag = "Player";

    // Method called when the collider enters a collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the player tag
        if (collision.gameObject.tag == playerTag)
        {
            // Enable the UI panel
            if (panel != null)
            {
                panel.SetActive(true);
                Debug.Log("Player collided. Panel enabled.");
            }
            else
            {
                Debug.LogWarning("Panel reference is not set.");
            }
        }
    }
}