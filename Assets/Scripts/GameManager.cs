using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0; // Player's score
    public TextMeshProUGUI scoreText; // TextMeshProUGUI to display the score

    // Method to increase the score
    public void IncreaseScore()
    {
        score++;
        UpdateScoreText();
    }

    // Method to update the score text in the UI
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "moneh: " + score.ToString();
        }
    }
}