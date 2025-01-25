using UnityEngine;
using UnityEngine.UI; // Necesario si usas UI para mostrar la puntuaci�n

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Texto de UI para mostrar la puntuaci�n en pantalla
    private int currentScore = 0; 

    // M�todo para a�adir puntos
    public void AddScore(int points)
    {
        Debug.Log("�+asfgafasfsafsf!");

        currentScore += points;
        UpdateScoreText();
    }

    // M�todo para reiniciar la puntuaci�n
    public void ResetScore()
    {
        currentScore = 0;
    }

    // Actualizar el texto en pantalla
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = currentScore.ToString();
        }
    }

    // Obtener la puntuaci�n actual (opcional)
    public int GetScore()
    {
        return currentScore;
    }
}