using UnityEngine;

public class SecondGameManager : MonoBehaviour
{
    public static SecondGameManager Instance { get; private set; }

    public int moneh;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddMoneh(int amount)
    {
        moneh += amount;
        Debug.Log("Moneh added: " + amount + ", Total Moneh: " + moneh);
    }

    public void SpendMoneh(int amount)
    {
        if (moneh >= amount)
        {
            moneh -= amount;
            Debug.Log("Moneh spent: " + amount + ", Total Moneh: " + moneh);
        }
        else
        {
            Debug.Log("Not enough moneh!");
        }
    }
}