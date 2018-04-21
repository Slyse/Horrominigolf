using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBehavior : MonoBehaviour {

    public GameObject player;
    public Camera playercamera;

    private void OnTriggerEnter(Collider other) {
        if (other.name == "NikoEyeball") {
            print("ping");
            //playercamera.transform.parent = null;
            Destroy(player);
            
                // vois freezaa pelin ja heittää gameover tms ruutuun display text on screen
                
        }
    }
}