using UnityEngine;
using UnityEngine.UI; // Necesario si usas UI para mostrar la puntuaci�n

public class AmmoManager : MonoBehaviour
{
    private int currentAmmo = 6;


    public void AddAmmo() // Solo se puede de uno en uno
    {
        currentAmmo++;
        UpdateScoreText();
    }

    // M�todo para reiniciar la puntuaci�n
    public void ResetAmmo()
    {
        currentScore = 6;
    }

    public void ShowAmmo()
    {
        // Cambiar imagen
    }

    // Obtener la puntuaci�n actual (opcional)
    public int GetAmmo()
    {
        return currentAmmo;
    }
}