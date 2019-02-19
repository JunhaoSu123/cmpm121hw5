using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchR : MonoBehaviour
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
        BedRoomCamera.GetComponent<Camera>().enabled = false;
        LivingRoomCamera.GetComponent<Camera>().enabled = false;
        RestRoomCamera.GetComponent<Camera>().enabled = true;
    }
}
