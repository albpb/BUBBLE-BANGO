using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float minFloatingSpeed = 6f;
    public float maxFloatingSpeed = 10f;
    public float oscillationSpeed = 4f;
    public float oscillationAmplitude = 0.02f;

    public float maxLifeTimer = 5f;

    private float floatingSpeed;
    private float startTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        floatingSpeed = Random.Range(minFloatingSpeed, maxFloatingSpeed);

        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = floatingSpeed * Time.deltaTime;

        float horizontalMovement = Mathf.Sin(Time.time* oscillationSpeed) * oscillationAmplitude;

        transform.Translate(new Vector3(horizontalMovement, verticalMovement, 0));

        manageClick();

        if (Time.time - startTime > maxLifeTimer)
        {
            Destroy(gameObject);
        }
    }

    void manageClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject == gameObject)
                {
                    onClick();
                }
            }
        }
    }
    protected virtual void onClick()
    {
        Destroy(gameObject);
    }
}
