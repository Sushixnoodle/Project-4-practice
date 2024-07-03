using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import the TextMeshPro namespace

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI monehText; // Use TextMeshProUGUI for UI text


    private void Update()
    {
        if (SecondGameManager.Instance != null)
        {
            monehText.text = "Moneh: " + SecondGameManager.Instance.moneh.ToString();
        }
    }

    public void AddMoneh(int amount)
    {
        SecondGameManager.Instance.AddMoneh(amount);
        UpdateMonehUI();
    }

    public void SpendMoneh(int amount)
    {
        SecondGameManager.Instance.SpendMoneh(amount);
        UpdateMonehUI();
    }

    private void UpdateMonehUI()
    {
        monehText.text = "Moneh: " + SecondGameManager.Instance.moneh.ToString();
    }
}