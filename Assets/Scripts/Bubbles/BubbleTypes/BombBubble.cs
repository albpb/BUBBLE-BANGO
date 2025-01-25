using UnityEngine;

public class BoomBubble : Bubble
{
    public GameOverScreen GameOverScreen;

    protected override void onClick()
    {
        Debug.Log("¡Boom! Explosive Bubble clicked!");
        Destroy(gameObject);
        GameOverScreen.BeginGameOver(0);
    }
}