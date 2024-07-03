using UnityEngine;
using TMPro; // Make sure to include this namespace

public class DisableTextMeshProScript : MonoBehaviour
{
    // Reference to the TextMeshPro component you want to disable
    public TextMeshProUGUI textMeshPro;

    void Update()
    {
        // Check if the "K" key is pressed
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DisableTextMeshPro();
        }
    }

    void DisableTextMeshPro()
    {
        // Check if the TextMeshPro component is assigned
        if (textMeshPro != null)
        {
            // Disable the TextMeshPro component
            textMeshPro.enabled = false;
        }
        else
        {
            Debug.LogWarning("TextMeshPro component is not assigned in the inspector.");
        }
    }
}