using UnityEngine;

public class AmmoBubble : Bubble
{

    private AmmoManager ammoManager;
    private ScoreManager scoreManager;

    private void Awake()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
        ammoManager = FindAnyObjectByType<AmmoManager>();
    }

    protected override void onClick()
    {
        if (!FindAnyObjectByType<GameOverManager>().gameOver)
        {
            Debug.Log("¡+1 Bullet! Ammo Bubble clicked!");

            scoreManager.AddScore(100);

            ammoManager.AddAmmo(Random.Range(2, 4));


            Destroy(gameObject);
        }
    }
}