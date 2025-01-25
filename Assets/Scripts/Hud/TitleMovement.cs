using UnityEngine;

public class TitleMovement : MonoBehaviour
{
    public float sizeAmount = 0.1f;
    public float sizeSpeed = 1f;

    private bool scalingUp = true;
    private float initialScale;

    void Start()
    {
        initialScale = transform.localScale.x;
    }

    void Update()
    {
        float scaleDirection = scalingUp ? 1f : -1f;
        transform.localScale = new Vector3(initialScale + sizeAmount * scaleDirection * Mathf.PingPong(Time.time * sizeSpeed, 1), transform.localScale.y, transform.localScale.z);

        if (transform.localScale.x >= initialScale + sizeAmount)
        {
            scalingUp = false;
        }
        else if (transform.localScale.x <= initialScale)
        {
            scalingUp = true;
        }
    }
}
