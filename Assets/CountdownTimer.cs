using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 60f; // Waktu awal (dalam detik)
    public TextMeshProUGUI timerText;

    private bool isGameOver = false;

    void Update()
    {
        if (!isGameOver)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerUI();
            }
            else
            {
                timeRemaining = 0;
                isGameOver = true;
                GameOver();
            }
        }
    }

    void UpdateTimerUI()
    {
        timerText.text = "Time: " + Mathf.Ceil(timeRemaining);
    }

    void GameOver()
    {
        Debug.Log("Game Over!"); // Bisa diganti dengan fungsi Game Over
    }
}
