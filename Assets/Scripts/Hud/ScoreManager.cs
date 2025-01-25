using UnityEngine;
using UnityEngine.UI; // Necesario si usas UI para mostrar la puntuación

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Texto de UI para mostrar la puntuación en pantalla
    public Text x2Timer;
    public int currentScore = 0;

    private float timer = 0f;
    private bool isTimerActive = false;

    private void Update()
    {
        if (isTimerActive)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                DeactivateTimer();
            }
            else
            {
                DrawTimer();
            }
        }
    }

    public void ActivateTimer()
    {
        timer = 20f;
        isTimerActive = true;
    }

    private void DeactivateTimer()
    {
        isTimerActive = false;
        timer = 0f;
        x2Timer.text = "";
    }

    // Método para añadir puntos
    public void AddScore(int points)
    {
        if (isTimerActive)
        {
            points *= 2;
        }
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
            // Formatear el número
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

    // Obtener la puntuación actual (opcional)
    public int GetScore()
    {
        return currentScore;
    }
    public void DrawTimer()
    {
        if (x2Timer != null)
        {
            x2Timer.text = Mathf.Ceil(timer).ToString() + " - x2!";
        }
    }
}
