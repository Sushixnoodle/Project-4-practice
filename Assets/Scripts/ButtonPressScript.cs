using UnityEngine;
using UnityEngine.UI; // Make sure to include this if you are working with UI elements

public class ButtonPressScript : MonoBehaviour
{
    public Button myButton; // Reference to the button you want to "press"

    void Update()
    {
        // Check if the "6" key is pressed
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            PressButton();
        }
    }

    void PressButton()
    {
        // Check if the button is assigned
        if (myButton != null)
        {
            // Simulate button press
            myButton.onClick.Invoke();
        }
        else
        {
            Debug.LogWarning("Button not assigned in the inspector.");
        }
    }
}