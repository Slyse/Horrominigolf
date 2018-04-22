using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoleBehavior : MonoBehaviour {

    public GameObject player;
    public Camera playercamera;
    public Text statusText;

    void Start() {
        statusText.text = "";
    }

    private void OnTriggerEnter(Collider other) {
        if (other.name == "NikoEyeball") {
            print("ping");
            //playercamera.transform.parent = null;
            Destroy(player);
            statusText.text = "YARRR!! YOU GOT EATEN!";
            Time.timeScale = 0f;
            // vois freezaa pelin ja heittää gameover tms ruutuun display text on screen

        }
    }
}