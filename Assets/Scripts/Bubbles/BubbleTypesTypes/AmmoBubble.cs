using UnityEngine;

public class AmmoBubble : Bubble
{
    protected override void onClick()
    {
        Debug.Log("¡+1 Bullet! Ammo Bubble clicked!");
        Destroy(gameObject);
    }
}