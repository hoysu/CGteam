using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2Controller : MonoBehaviour
{
    public GameObject Pivot;

    private void OnTriggerEnter(Collider other)
    {
        Pivot.GetComponent<Animator>().SetInteger("door2state", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        Pivot.GetComponent<Animator>().SetInteger("door2state", 2);
    }
}
