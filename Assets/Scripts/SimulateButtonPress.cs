using UnityEngine;
using UnityEngine.UI;

public class SimulateButtonPress : MonoBehaviour
{
    // Reference to the button you want to simulate a press on
    public Button targetButton;

    void Update()
    {
        // Check if the "2" key is pressed
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Simulate a button press
            if (targetButton != null)
            {
                targetButton.onClick.Invoke();
            }
        }
    }
}