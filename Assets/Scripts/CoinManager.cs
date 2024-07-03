using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance { get; private set; }
    public int CoinCount { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }



    public void AddCoins(int amount)
    {
        CoinCount += amount;
        // Optionally, save to PlayerPrefs if you want to persist after closing the game
        PlayerPrefs.SetInt("CoinCount", CoinCount);
    }

    public void SetCoins(int amount)
    {
        CoinCount = amount;
        PlayerPrefs.SetInt("CoinCount", CoinCount);
    }

    public void LoadCoins()
    {
        CoinCount = PlayerPrefs.GetInt("CoinCount", 0);
    }
}