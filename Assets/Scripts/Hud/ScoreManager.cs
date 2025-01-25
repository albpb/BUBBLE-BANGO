using UnityEngine;
using UnityEngine.UI; // Necesario si usas UI para mostrar la puntuación

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Texto de UI para mostrar la puntuación en pantalla
    private int currentScore = 0; 

    // Método para añadir puntos
    public void AddScore(int points)
    {
        Debug.Log("¡+asfgafasfsafsf!");

        currentScore += points;
        UpdateScoreText();
    }

    // Método para reiniciar la puntuación
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

    // Obtener la puntuación actual (opcional)
    public int GetScore()
    {
        return currentScore;
    }
}