﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAimDirection : MonoBehaviour {

   // public Transform rayStartingPoint;
    public Transform beam;
    public float beamLenght;
    public GameObject nikoEyeball;
    Rigidbody rb;

    void Start() {
        rb = nikoEyeball.GetComponent<Rigidbody>();
    }

    void Update() {
        if (rb.velocity.magnitude < 0.1f) {
            if (Input.GetMouseButtonDown(0)) {
                beam.gameObject.SetActive(true);
                beam.localScale = new Vector3(1, 1, beamLenght);
            }
        }
         if(Input.GetMouseButtonUp(0)) {
            beam.gameObject.SetActive(false);
        }

        /*
        RaycastHit hitInfo;
        
        Physics.Raycast(rayStartingPoint.position, rayStartingPoint.forward, out hitInfo);
        
        

    */






        


    }

}