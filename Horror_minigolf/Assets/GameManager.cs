using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    private bool Levelover = false;
    public Text statusText;

   public void StartNextLevel() {
        Levelover = true;
            statusText.text = "Level Completed!\n Press SPACE to continue";
    }
    private void Update() {
        if (Levelover && Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1f;
        }
    }
}
