using UnityEngine;
using UnityEngine.UI; // Necesario si usas UI para mostrar la puntuaci�n

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Texto de UI para mostrar la puntuaci�n en pantalla
    public int currentScore = 0; 

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
            // Formatear el n�mero
            if (currentScore >= 1000000) // Millones
            {
                float scoreInMillions = currentScore / 1000000f;
                scoreText.text = scoreInMillions.ToString("0.0") + "M";
            }
            else if (currentScore >= 1000) // Miles
            {
                float scoreInThousands = currentScore / 1000f;
                scoreText.text = scoreInThousands.ToString("0.0") + "K";
            }
            else
            {
                scoreText.text = currentScore.ToString(); // Menos de mil
            }
        }
    }

    // Obtener la puntuaci�n actual (opcional)
    public int GetScore()
    {
        return currentScore;
    }
}