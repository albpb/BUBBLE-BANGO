using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D customCursor;
    [SerializeField] private Vector2 hotSpot = Vector2.zero;

    private static CursorManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SetCustomCursor();
    }

    private void SetCustomCursor()
    {
        Cursor.SetCursor(customCursor, hotSpot, CursorMode.Auto);
    }

    public void ResetCursor()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
