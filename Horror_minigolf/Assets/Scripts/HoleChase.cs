using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleChase : MonoBehaviour {
    public Transform nikoEyeball;
    public float speed;
    bool chasing;

    public void StartChase() {
        chasing = true;
    }

    void Update() {
        if (chasing) {
            float move = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, nikoEyeball.position, move);
        }
    }
}