using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private bool isMoving = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isMoving)
        {
            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                rb.constraints = RigidbodyConstraints2D.FreezePositionY;

                if (Input.GetAxisRaw("Horizontal") > 0)
                {
                    MoveToWall(Vector2.right);
                }
                else
                {
                    MoveToWall(Vector2.left);
                }
            }
            else if (Input.GetAxisRaw("Vertical") != 0)
            {
                rb.constraints = RigidbodyConstraints2D.FreezePositionX;

                if (Input.GetAxisRaw("Vertical") > 0)
                {
                    MoveToWall(Vector2.up);
                }
                else
                {
                    MoveToWall(Vector2.down);
                }
            }
        }
    }

    void MoveToWall(Vector2 direction)
    {
        // Ignore the player's own collider
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, Mathf.Infinity, ~LayerMask.GetMask("Player"));
        Debug.DrawRay(transform.position, direction * 100, Color.red, 2f); // Visualize the ray

        if (hit.collider != null)
        {
            Debug.Log("Hit " + hit.collider.name);
            StartCoroutine(MoveToPosition(hit.point));
        }
        else
        {
            Debug.Log("No hit detected");
        }
    }

    IEnumerator MoveToPosition(Vector2 target)
    {
        isMoving = true;
        Vector2 startPos = rb.position;
        float elapsedTime = 0;
        float journeyLength = Vector2.Distance(startPos, target);

        while (Vector2.Distance(rb.position, target) > 0.01f)
        {
            elapsedTime += Time.deltaTime;
            float fractionOfJourney = elapsedTime * speed / journeyLength;
            rb.position = Vector2.Lerp(startPos, target, fractionOfJourney);
            yield return null;
        }

        rb.position = target;
        isMoving = false;
        rb.constraints = RigidbodyConstraints2D.None; // Reset constraints
        rb.constraints = RigidbodyConstraints2D.FreezeRotation; // Only freeze rotation
    }

    private void FixedUpdate()
    {
        // No need to set the velocity since we are directly setting the position
        rb.velocity = Vector2.zero;
    }
}