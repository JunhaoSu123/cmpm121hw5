using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject BedRoomCamera;
    public GameObject LivingRoomCamera;
    public GameObject RestRoomCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    

        void OnTriggerEnter(Collider other)
        {
            BedRoomCamera.GetComponent<Camera>().enabled = true;
            LivingRoomCamera.GetComponent<Camera>().enabled = false;
            RestRoomCamera.GetComponent<Camera>().enabled = false;
        }

}

