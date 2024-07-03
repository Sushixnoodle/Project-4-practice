using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject specificPanel; // Assign your panel in the inspector
    public string levels = "TargetScene"; // The name of the scene to switch to
    public string nextLevel = "TargetScene";
    public string retry = "TargetScene";
    void Update()
    {
        // Check if the specific panel is active
        if (specificPanel.activeSelf)
        {
            // Check if the 'A' key is pressed
            if (Input.GetKeyDown(KeyCode.A))
            {
                // Load the target scene
                SceneManager.LoadScene(levels);
            }


            
            if (Input.GetKeyDown(KeyCode.S))
            {
                
                SceneManager.LoadScene(nextLevel);
            }

            
            if (Input.GetKeyDown(KeyCode.Q))
            {
                
                SceneManager.LoadScene(retry);
            }
        }
    }
}