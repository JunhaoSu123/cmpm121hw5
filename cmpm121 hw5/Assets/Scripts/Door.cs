using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator DoorAnim;
    public static int OpenD;
    // Start is called before the first frame update
    void Start()
    {
        DoorAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        OpenD = KnightMovement.count;
        if (OpenD > 1)
        {
            DoorAnim.SetInteger("OpenD", 2);
        }
    }
}
