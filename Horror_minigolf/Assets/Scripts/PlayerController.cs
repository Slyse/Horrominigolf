using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    public float sensitivity;
    public string HorizontalAim;
    public Vector3 axis;
    public Transform player;
    public Transform beam;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
  
        transform.Rotate(axis, Input.GetAxis(HorizontalAim) * sensitivity, 0);
        if (rb.velocity.magnitude < 0.1f) {
            if (Input.GetKeyUp(KeyCode.Mouse0)) {
                rb.velocity = (beam.position - rb.position).normalized * 10f;
            }
        }
        //rb:n avulla liikutta, ei transformilla
    }
}
