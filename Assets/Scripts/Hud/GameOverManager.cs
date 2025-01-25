using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Text pointsText;

    public Text loseReason;

    public GameObject gameOverScreen;

    public ScoreManager scoreManager;

    public bool gameOver;
    public void ShowGameOver(string loseReasonText)
    {
        gameOverScreen.SetActive(true);
        pointsText.text = "¡ " + scoreManager.currentScore.ToString() + " points !";
        loseReason.text = loseReasonText;
        gameOver = true;
    }
}
