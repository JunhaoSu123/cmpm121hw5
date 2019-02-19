using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCamera : MonoBehaviour
{
    public Transform OneAxisFollow;
    public Transform Player;
    //GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        //Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        OneAxisFollow.position = new Vector3(-17.72f, 3f, Player.position.z);
        //Vector3 PlayerPosition = new Vector3(Player.transform.position.x, 
                                               //transform.position.y, 
                                               //Player.transform.position.z);
        //transform.LookAt(PlayerPosition);
    }
}
