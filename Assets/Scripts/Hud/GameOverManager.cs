using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    public Text pointsText;
    public Text loseReason;
    public GameObject gameOverScreen;
    public ScoreManager scoreManager;
    public bool gameOver;

    private AmmoManager ammoManager;

    private void Awake()
    {
        ammoManager = FindAnyObjectByType<AmmoManager>();
    }

    public void ShowGameOver(string loseReasonText)
    {
        StartCoroutine(ShowGameOverWithDelay(loseReasonText));
    }

    private IEnumerator ShowGameOverWithDelay(string loseReasonText)
    {
        yield return new WaitForSeconds(0.1f);

        if (ammoManager.GetAmmo() == 0)
        {
            gameOverScreen.SetActive(true);
            pointsText.text = "¡ " + scoreManager.currentScore.ToString() + " points !";
            loseReason.text = loseReasonText;
            gameOver = true;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
