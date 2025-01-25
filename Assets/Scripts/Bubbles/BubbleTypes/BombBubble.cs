using UnityEngine;

public class BoomBubble : Bubble
{
    protected override void onClick()
    {
        if (!FindAnyObjectByType<GameOverManager>().gameOver)
        {
            Debug.Log("¡Boom! Explosive Bubble clicked!");

            FindAnyObjectByType<GameOverManager>().ShowGameOver("You got poisoned by Bongo!");

            Destroy(gameObject);
        }
    }
}