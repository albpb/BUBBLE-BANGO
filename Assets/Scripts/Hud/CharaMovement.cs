using UnityEngine;

public class CharaMovement : MonoBehaviour
{
    public float rotationAmount = 5f;
    public float rotationSpeed = 5f;
    public float sizeAmount = 0.1f;
    public float sizeSpeed = 1f;

    private float currentRotation = 0f;
    private bool rotatingRight = true;
    private bool scalingUp = true;

    private float initialScale;

    void Start()
    {
        initialScale = transform.localScale.x;
    }

    void Update()
    {
        if (rotatingRight)
        {
            currentRotation += rotationSpeed * Time.deltaTime;
            if (currentRotation >= rotationAmount)
            {
                rotatingRight = false;
            }
        }
        else
        {
            currentRotation -= rotationSpeed * Time.deltaTime;
            if (currentRotation <= -rotationAmount)
            {
                rotatingRight = true;
            }
        }

        transform.rotation = Quaternion.Euler(0, 0, currentRotation);

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
