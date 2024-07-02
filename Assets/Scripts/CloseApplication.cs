using UnityEngine;

public class CloseApplication : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void CloseApp()
    {
        Debug.Log("Close button was pressed");
        // Close the application
        Application.Quit();

        // If we are running in the Unity editor, stop playing the scene
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}