using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector2 offset; // Offset to be maintained between the player and the camera
    public Vector2 boundary; // Boundary within which the camera will move

    private void LateUpdate()
    {
        if (player != null)
        {
            Vector3 targetPosition = player.position + (Vector3)offset;

            // Calculate the boundaries
            float leftBoundary = targetPosition.x - boundary.x;
            float rightBoundary = targetPosition.x + boundary.x;
            float bottomBoundary = targetPosition.y - boundary.y;
            float topBoundary = targetPosition.y + boundary.y;

            // Move the camera to follow the player while respecting the boundaries
            Vector3 newPosition = transform.position;

            if (transform.position.x < leftBoundary)
            {
                newPosition.x = leftBoundary;
            }
            else if (transform.position.x > rightBoundary)
            {
                newPosition.x = rightBoundary;
            }

            if (transform.position.y < bottomBoundary)
            {
                newPosition.y = bottomBoundary;
            }
            else if (transform.position.y > topBoundary)
            {
                newPosition.y = topBoundary;
            }

            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
    }
}