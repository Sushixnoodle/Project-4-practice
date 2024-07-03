using UnityEngine;

public class HideCursorScript : MonoBehaviour
{
    void Start()
    {
        // Hide the cursor and lock it in the center of the screen
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

   /* void Update()
    {
        // You can add additional logic here if needed, for example, showing the cursor when a key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Show the cursor and unlock it
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }*/
}