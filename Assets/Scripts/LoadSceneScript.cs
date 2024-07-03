using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    // The name of the scene you want to load
    public string sceneName;

    void Update()
    {
        // Check if the "J" key is pressed
        if (Input.GetKeyDown(KeyCode.J))
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        // Check if the scene name is not empty
        if (!string.IsNullOrEmpty(sceneName))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene name is not assigned.");
        }
    }
}