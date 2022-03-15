using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caballero : MonoBehaviour {
    public Animator animador;

    private Rigidbody _rb;

    public float speed;

    private Vector3 _totalVelocity;

    private void Start() {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        _totalVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.A)) {
             _totalVelocity = -transform.right  * speed;
        } else if (Input.GetKey(KeyCode.D)) {
            _totalVelocity =  transform.right  * speed;
        }
        
        if (Input.GetKey(KeyCode.W)) {
            _totalVelocity +=  transform.forward  * speed;
        } else if (Input.GetKey(KeyCode.S)) {
            _totalVelocity += -transform.forward  * speed;
        }

        if (_rb.velocity.magnitude > 0.3f) {
            animador.SetBool("Caminando",true);
        }
        else {
            animador.SetBool("Caminando",false);
        }

        _rb.velocity = _totalVelocity;
        

        if(Input.GetMouseButtonDown(0)){
            animador.SetTrigger("Ataca");
        }        
    }
}
