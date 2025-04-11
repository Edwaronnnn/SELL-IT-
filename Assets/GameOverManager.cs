using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel; // Panel yang berisi Game Over UI
    public Image gameOverImage; // Gambar Game Over
    public Button restartButton; // Button Restart

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        gameOverImage.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
