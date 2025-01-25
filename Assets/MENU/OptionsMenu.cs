using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public AudioMixer audiomixer;

    public void SetVolume (float volume) {
        //Debug.Log(volume);
        audiomixer.SetFloat("Volume", volume);
    }
}
