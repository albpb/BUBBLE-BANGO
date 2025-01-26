using System.Collections;
using UnityEngine;

public class x2Bubble : Bubble
{
    [SerializeField] private AudioClip bubblePop;

    public ScoreManager scoreManager;

    private void Awake()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    protected override void onClick()
    {
        if (!FindAnyObjectByType<GameOverManager>().gameOver)
        {
            Debug.Log("¡x2 Points! x2 Bubble clicked!");

            scoreManager.ActivateTimer();

            ControladorSonidos.Instance.EjecSonido(bubblePop);

            Destroy(gameObject);
        }
    }
}
