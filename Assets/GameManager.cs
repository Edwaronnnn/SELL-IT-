using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;
    
    private AudioSource audioSource;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    public float gameTimeRestart = 60f;
    public float gameTime = 60f; // ⏳ Waktu permainan dalam detik
    private float currentTime;
    public TextMeshProUGUI timerText; // 🕒 UI untuk menampilkan waktu
    public GameObject gameOverPanel; // 🎮 UI untuk Game Over
    public GameObject retryButton;
    public GameObject gameOver;




    private bool isGameOver = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
        if (!isGameOver)
        {
            gameTime -= Time.deltaTime; // Kurangi waktu setiap frame
            UpdateTimerUI();

            if (gameTime <= 0)
            {
                GameOver();
            }
        }
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
        {
            timerText.text = "Time: " + Mathf.CeilToInt(gameTime);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreUI();
        PlaySound(correctSound);
    }

    public void ReduceScore(int amount)
    {
        score -= amount;
        if (score < 0) score = 0;
        UpdateScoreUI();
        PlaySound(wrongSound);
        gameTime = 0;
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }

    void GameOver()
    {
        isGameOver = true;
        gameTime = gameTimeRestart;
        gameOverPanel.SetActive(true); // Tampilkan panel Game Over
        gameOver.SetActive(true);
        retryButton.SetActive(true);
        isGameOver = false;
    }


}
