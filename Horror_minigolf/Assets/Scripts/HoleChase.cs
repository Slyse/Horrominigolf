using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleChase : MonoBehaviour {
    public Transform nikoEyeBall;
    public float speed;
   // int checkpoints;
    // public int maxCheckpoints;

    void Update() {

        float move = speed * Time.deltaTime;

        //while ( checkpoints < maxCheckpoints) {
            //if(checkpoints == 1) {
                transform.position = Vector3.MoveTowards(transform.position, nikoEyeBall.position, move);
           // }
        //}



        
        
    }

}
