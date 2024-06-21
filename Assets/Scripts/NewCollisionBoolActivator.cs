using UnityEngine;

public class PlayerCollisionEnablePanel : MonoBehaviour
{
    // Reference to the UI panel to be enabled
    public GameObject panel;

    // Tag of the object to collide with
    public string targetTag = "TargetObject";

    // Method called when the collider enters a collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the target tag
        if (collision.gameObject.tag == targetTag)
        {
            // Enable the UI panel
            if (panel != null)
            {
                panel.SetActive(true);
                Debug.Log("Collision detected with target object. Panel enabled.");
            }
            else
            {
                Debug.LogWarning("Panel reference is not set.");
            }
        }
    }
}