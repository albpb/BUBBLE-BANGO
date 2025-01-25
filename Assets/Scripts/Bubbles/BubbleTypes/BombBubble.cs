using UnityEngine;

public class BoomBubble : Bubble
{

    protected override void onClick()
    {
        Debug.Log("¡Boom! Explosive Bubble clicked!");
        Destroy(gameObject);
    }
}