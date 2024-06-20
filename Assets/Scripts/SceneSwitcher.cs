using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject specificPanel; // Assign your panel in the inspector
    public string targetSceneName = "TargetScene"; // The name of the scene to switch to

    void Update()
    {
        // Check if the specific panel is active
        if (specificPanel.activeSelf)
        {
            // Check if the 'A' key is pressed
            if (Input.GetKeyDown(KeyCode.A))
            {
                // Load the target scene
                SceneManager.LoadScene(targetSceneName);
            }
        }
    }
}