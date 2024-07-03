using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene(string Level2)
    {
        SceneManager.LoadScene(Level2);
    }
}