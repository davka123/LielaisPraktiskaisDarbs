using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beigas : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("tests");
        GameObject.Find("FPSController").SendMessage("beigas");

    }
}
