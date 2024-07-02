using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SimulateTwo : MonoBehaviour
{
    // Reference to the button you want to simulate a press on
    public Button targetButton;

    // The name of the scene to load
    public string sceneName;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Log to the console for debugging purposes
            Debug.Log("K key was pressed");

            // Simulate a button press
            if (targetButton != null)
            {
                targetButton.onClick.Invoke();
                // Load the specified scene
                LoadScene();
            }
        }
    }

    // Method to load the specified scene
    void LoadScene()
    {
        // Log to the console for debugging purposes
        Debug.Log("Loading scene: " + sceneName);

        // Load the scene by name
        SceneManager.LoadScene(sceneName);
    }
}