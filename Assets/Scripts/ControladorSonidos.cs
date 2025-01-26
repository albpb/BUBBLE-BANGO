using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorSonidos : MonoBehaviour
{
    public static ControladorSonidos Instance;
    private AudioSource audioSource;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }

    public void EjecSonido(AudioClip sonido)
    {
        audioSource.PlayOneShot(sonido);
    }
    public void EjecSonidoConLoop(AudioClip sonido, bool loop)
    {
        audioSource.clip = sonido;
        audioSource.loop = loop;
        audioSource.Play();
    }

    public void PararSonidos()
    {
        audioSource.Stop();
    }

    public void CambiarVol(float valor)
    {
        audioSource.volume = valor;
    }

}
