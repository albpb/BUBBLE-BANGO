using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;

    public void BeginGameOver(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " points";
    }
}
