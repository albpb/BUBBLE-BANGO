using UnityEngine;


public class Button : MonoBehaviour
{
    public AmmoManager ammoManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ammoManager.SubAmmo();
        }
    }

}
