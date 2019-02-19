using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    Animator Door1Anim;
    public static int OpenD1;
    // Start is called before the first frame update
    void Start()
    {
        Door1Anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        OpenD1 = KnightMovement.count;
      if (OpenD1 > 0)
       {
           Door1Anim.SetInteger("OpenDoor", 1);
      }
    }
}
