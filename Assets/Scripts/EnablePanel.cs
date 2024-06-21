using UnityEngine;
using UnityEngine.UI;

public class EnablePanel : MonoBehaviour
{
    public GameObject panel; // Reference to the panel you want to enable
    public Button button; // Reference to the button inside the panel

    void Start()
    {
        // Ensure the panel is inactive at the start
        panel.SetActive(false);

        // Add a listener to the button
        button.onClick.AddListener(OnButtonClick);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            panel.SetActive(true);
        }
    }

    void OnButtonClick()
    {
        Debug.Log("Button was clicked!");
        // Add any additional logic for when the button is clicked
    }
}