using UnityEngine;

public class ClickManager : MonoBehaviour
{
    [SerializeField] private AudioClip shot;

    public AmmoManager ammoManager;
    // Update is called once per frame
    void Update()
    {
        if (!FindAnyObjectByType<GameOverManager>().gameOver)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ammoManager.SubAmmo();
                // efecto de sonido de bang bang
                ControladorSonidos.Instance.EjecSonido(shot);
            }
        }
    }
}
