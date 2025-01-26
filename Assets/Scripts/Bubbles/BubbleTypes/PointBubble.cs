using UnityEngine;
using System.Collections;

public class PointBubble : Bubble
{
    private ScoreManager scoreManager;
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
            Debug.Log("¡+1 Point! Point Bubble clicked!");

            scoreManager.AddScore(50);
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

        Destroy(gameObject);
    }
}