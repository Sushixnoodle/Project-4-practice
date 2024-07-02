using UnityEngine;
using UnityEngine.UI;

public class Simulate2 : MonoBehaviour
{
    // Reference to the button you want to simulate a press on
    public Button targetButton;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            // Simulate a button press
            if (targetButton != null)
            {
                targetButton.onClick.Invoke();
            }
        }
    }
}