using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1;  // Ensure the game is not paused
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
