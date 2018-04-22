using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour {

    public void Disable() {
        GetComponent<Camera>().enabled = false;
    }
}
