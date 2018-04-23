using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerEnd : MonoBehaviour {

    public GameManager gm;

    void OnTriggerEnter(Collider other) {
        if(other.name == "NikoEyeball") {
            GameObject.FindObjectOfType<HoleChase>().EndChase();
            Time.timeScale = 0f;
            gm.StartNextLevel();
            
        }

    }
}
