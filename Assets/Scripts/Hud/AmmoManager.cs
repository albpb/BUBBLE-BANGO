using UnityEngine;
using UnityEngine.UI; // Necesario si usas UI para mostrar la puntuaci�n

public class AmmoManager : MonoBehaviour
{
    private int currentAmmo = 6;

    public Sprite[] slicedSprites; // Aqu� guardaremos las partes del sprite sliced, a�adir desde unity

    public SpriteRenderer targetSpriteRenderer; // SpriteRenderer del objeto

    private void Start()
    {
        ShowSprite();
    }

    public void ShowSprite()
    {
        if (slicedSprites.Length == 0 || targetSpriteRenderer == null)
            return;
        targetSpriteRenderer.sprite = slicedSprites[currentAmmo];
    }

    public void AddAmmo() 
    {
        if (currentAmmo < 6)
        {
            currentAmmo++;
            ShowSprite();
        }
    }

    public void AddAmmo(int ammo)
    {
        if (currentAmmo < 6)
        {
            currentAmmo += ammo;
            ShowSprite();
        }
    }

    public void SubAmmo() 
    {

        if (currentAmmo > 0)
        {
            currentAmmo--;
            ShowSprite();
        }
    }

    // M�todo para reiniciar la puntuaci�n
    public void ResetAmmo()
    {
        currentAmmo = 6;
        ShowSprite();
    }


    public int GetAmmo()
    {
        return currentAmmo;
    }
}