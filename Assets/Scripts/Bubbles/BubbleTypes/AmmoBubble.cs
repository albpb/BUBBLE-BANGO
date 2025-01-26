using UnityEngine;
using System.Collections;


public class AmmoBubble : Bubble
{
    [SerializeField] private AudioClip reload;
    [SerializeField] private AudioClip bubblePop;

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

            ammoManager.AddAmmo(Random.Range(2, 4));

            animator.SetBool("Clicked", true);
            StartCoroutine(DestroyAfterAnimation());

        }
    }
    private IEnumerator DestroyAfterAnimation()
    {

        ControladorSonidos.Instance.EjecSonido(reload);
        ControladorSonidos.Instance.EjecSonido(bubblePop);

        // Obtener la duración de la animación activa
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        float animationDuration = stateInfo.length;

        yield return new WaitForSeconds(0.2f);

        Destroy(gameObject);
    }
}