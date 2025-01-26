using UnityEngine;
using System.Collections;


public class AmmoBubble : Bubble
{
    private Animator animator;

    private AmmoManager ammoManager;
    private ScoreManager scoreManager;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        scoreManager = FindAnyObjectByType<ScoreManager>();
        ammoManager = FindAnyObjectByType<AmmoManager>();
    }

    protected override void onClick()
    {
        if (!FindAnyObjectByType<GameOverManager>().gameOver)
        {
            Debug.Log("¡+1 Bullet! Ammo Bubble clicked!");

            scoreManager.AddScore(100);

            ammoManager.AddAmmo(Random.Range(2, 4));

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