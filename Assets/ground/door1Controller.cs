using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door1Controller : MonoBehaviour
{
    public GameObject Pivot;

    private void OnTriggerEnter(Collider other)
    {
        Pivot.GetComponent<Animator>().SetInteger("door1state", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        Pivot.GetComponent<Animator>().SetInteger("door1state", 2);
    }
}
