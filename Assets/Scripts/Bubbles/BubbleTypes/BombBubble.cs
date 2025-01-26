using UnityEngine;
using System.Collections;


public class BoomBubble : Bubble
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    protected override void onClick()
    {
        if (!FindAnyObjectByType<GameOverManager>().gameOver)
        {
            Debug.Log("¡Boom! Explosive Bubble clicked!");

            animator.SetBool("Clicked", true);
            DestroyAfterAnimation();

            FindAnyObjectByType<GameOverManager>().ShowGameOver("You got poisoned by Bongo!");

            Destroy(gameObject);
        }
    }

    private IEnumerator DestroyAfterAnimation()
    {
        // Obtener la duración de la animación activa
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        float animationDuration = stateInfo.length;

        yield return new WaitForSeconds(1);

    }
}