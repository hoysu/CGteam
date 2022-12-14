using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spacebaraction : MonoBehaviour
{
    Animator Anim;
    void Start()
    {
        string info = "[p] = play, [s] = stop";
        print(info);

        Anim = GetComponent<Animator>();
        Anim.speed = 0;
    }

    void Update()
    {
        /*****************************************************************
         * Unity KeyCode
         * https://docs.unity3d.com/kr/2020.3/ScriptReference/KeyCode.html
         *****************************************************************/
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Anim.speed == 1.0f) {
                print("stop");
                Anim.speed = 0f;
            }
            else
            {
                print("play");
                Anim.speed = 1.0f;
            }


        }

        
    }
}
