using UnityEngine;

public class MenuMusicManager : MonoBehaviour
{
    [SerializeField] private AudioClip menuMusic;
    void Start()
    {
        ControladorSonidos.Instance.PararSonidos();
        ControladorSonidos.Instance.EjecSonidoConLoop(menuMusic, true);
    }
}
