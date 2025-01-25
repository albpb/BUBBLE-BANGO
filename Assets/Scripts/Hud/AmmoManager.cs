using UnityEngine;
using UnityEngine.UI; // Necesario si usas UI para mostrar la puntuaci�n

public class AmmoManager : MonoBehaviour
{
    private int currentAmmo = 6;

    public Sprite[] slicedSprites; // Aqu� guardaremos las partes del sprite sliced, a�adir desde unity

    public Image image; // SpriteRenderer del objeto

    private void Start()
    {
        ShowSprite();
    }

    public void ShowSprite()
    {
        if (slicedSprites.Length == 0 || image == null)
            return;
        image.sprite = slicedSprites[currentAmmo];
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
            if (currentAmmo + ammo > 6) currentAmmo = 6;
            else
            {
                currentAmmo += ammo;
            }
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

        if(currentAmmo == 0)
        {
            FindAnyObjectByType<GameOverManager>().ShowGameOver("You ran out of bubblets!");
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