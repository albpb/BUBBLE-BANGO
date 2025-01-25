using UnityEngine;


public class Button : MonoBehaviour
{
    public AmmoManager ammoManager;
    public ScoreManager scoreManager;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ammoManager.SubAmmo();
            scoreManager.AddScore(100);
        }
    }

}
