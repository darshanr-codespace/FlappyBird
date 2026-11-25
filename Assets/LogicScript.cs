using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    void Awake()
    {
        PipeMoveScript.ResetMovement();

        if (scoreText == null)
            scoreText = FindAnyObjectByType<Text>();

        playerScore = 0;
        UpdateScoreText();
    }

    [ContextMenu("Increase Score")]
    public void AddScore()
    {
        playerScore += 1;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText == null)
        {
            Debug.LogError("Score Text is not assigned in the Inspector.");
            return;
        }

        scoreText.text = playerScore.ToString();
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void GameOver()
    {
        PipeMoveScript.StopMovement();
        gameOverScreen.SetActive(true);
    }
}
