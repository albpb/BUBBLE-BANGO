using UnityEngine;

public class GameMusicManager : MonoBehaviour
{
    [SerializeField] private AudioClip gameMusic;
    void Start()
    {
        ControladorSonidos.Instance.PararSonidos();
        ControladorSonidos.Instance.EjecSonidoConLoop(gameMusic, true);
    }
}
