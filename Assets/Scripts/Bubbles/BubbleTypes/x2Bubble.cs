using System.Collections;
using UnityEngine;

public class x2Bubble : Bubble
{
    [SerializeField] private AudioClip bubblePop;

    public ScoreManager scoreManager;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    protected override void onClick()
    {
        if (!FindAnyObjectByType<GameOverManager>().gameOver)
        {
            Debug.Log("¡x2 Points! x2 Bubble clicked!");

            scoreManager.AddScore(300);

            scoreManager.ActivateTimer();

            ControladorSonidos.Instance.EjecSonido(bubblePop);

            animator.SetBool("Clicked", true);

            StartCoroutine(DestroyAfterAnimation());
        }
    }

    private IEnumerator DestroyAfterAnimation()
    {
        // Obtener la duración de la animación activa
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        float animationDuration = stateInfo.length;

        yield return new WaitForSeconds(0.2f);

        ControladorSonidos.Instance.EjecSonido(bubblePop);

        Destroy(gameObject);
    }
}
