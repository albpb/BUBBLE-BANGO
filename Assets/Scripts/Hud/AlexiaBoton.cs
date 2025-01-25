using UnityEngine;
using UnityEngine.SceneManagement;

public class AlexiaBoton : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}