using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStart : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if(other.name == "NikoEyeball") {
            GameObject.FindObjectOfType<HoleChase>().StartChase();
        }
    }
}

