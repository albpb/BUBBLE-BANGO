using UnityEngine;

public class CameraManager : MonoBehaviour
{
    void Start()
    {
        float aspectRatio = Camera.main.aspect;

        float targetAspect = 16f / 9f;

        float scaleHeight = targetAspect / aspectRatio;
        float scaleWidth = aspectRatio / targetAspect;

        if (scaleHeight > 1f)
        {
            Camera.main.rect = new Rect(0, (1 - scaleHeight) / 2, 1, scaleHeight);
        }
        else
        {
            Camera.main.rect = new Rect((1 - scaleWidth) / 2, 0, scaleWidth, 1);
        }
    }
}
