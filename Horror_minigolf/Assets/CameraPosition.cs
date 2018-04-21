using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour {
    public Transform target;
    Vector3 difference;

    private void Start() {
        difference = transform.position - target.position;
        
    }
    void Update () {
        transform.position = target.position + difference;
	}
}
