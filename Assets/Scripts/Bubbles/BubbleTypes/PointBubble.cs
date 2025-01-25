using UnityEngine;

public class PointBubble : Bubble
{
    private ScoreManager scoreManager;

    private void Awake()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    protected override void onClick()
    {
        if (!FindAnyObjectByType<GameOverManager>().gameOver)
        {
            Debug.Log("¡+1 Point! Point Bubble clicked!");

            scoreManager.AddScore(50);

            Destroy(gameObject);
        }
    }
}