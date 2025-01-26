using UnityEngine;
using System.Collections;

public class BoomBubble : Bubble
{
    [SerializeField] private AudioClip boom;
    [SerializeField] private AudioClip bubblePop;

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

            FindAnyObjectByType<GameOverManager>().ShowGameOver("You got poisoned by Bongo!");

            StartCoroutine(DestroyAfterAnimation());
        }
    }

    private IEnumerator DestroyAfterAnimation()
    {
        ControladorSonidos.Instance.EjecSonido(boom);
        ControladorSonidos.Instance.EjecSonido(bubblePop);

        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        yield return new WaitForSeconds(stateInfo.length);

        Destroy(gameObject);
    }
}
