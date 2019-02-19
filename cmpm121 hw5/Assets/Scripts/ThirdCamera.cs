using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCamera : MonoBehaviour
{
    public Transform TwoAxisFollow;
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TwoAxisFollow.position = new Vector3(Player.position.x, 9f, Player.position.z);
    }
}
