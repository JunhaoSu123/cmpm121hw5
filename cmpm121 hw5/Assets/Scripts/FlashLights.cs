using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLights : MonoBehaviour
{
    public GameObject flashlight;
    
    //Light flashlight;
    private bool turnFlashlight = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            turnFlashlight = !turnFlashlight;
        }
        if(turnFlashlight == true)
        {
            flashlight.SetActive(true);
            Renderer render = GetComponent < Renderer > ();
            render.material.color = Color.white;
        }
        else
        {
            flashlight.SetActive(false);
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.yellow;
        }
    }
}
