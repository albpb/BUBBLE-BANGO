using UnityEngine;

public class PointBubble : Bubble
{
    protected override void onClick()
    {
        Debug.Log("¡+1 Point! Point Bubble clicked!");
        Destroy(gameObject);
    }
}