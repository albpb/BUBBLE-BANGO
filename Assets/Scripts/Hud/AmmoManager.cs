using UnityEngine;
using UnityEngine.UI; // Necesario si usas UI para mostrar la puntuación

public class AmmoManager : MonoBehaviour
{
    private int currentAmmo = 6;


    public void AddAmmo() // Solo se puede de uno en uno
    {
        currentAmmo++;
        UpdateScoreText();
    }

    // Método para reiniciar la puntuación
    public void ResetAmmo()
    {
        currentScore = 6;
    }

    public void ShowAmmo()
    {
        // Cambiar imagen
    }

    // Obtener la puntuación actual (opcional)
    public int GetAmmo()
    {
        return currentAmmo;
    }
}