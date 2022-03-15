using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    public int daño;

    public float velocidad;
    
    // Completar: Agregar función OnTriggerEnter, 
    //en ella: Checar si el objeto colisionado tiene componente SaludKart. Si la tiene, atacarlo.

    public void OnTriggerEnter(Collider kart){
        Debug.Log("Dispara");
        Atacar(kart.GetComponent<SaludKart>());

    }



    /// <summary>
    /// Esta parte hace que el proyectil se mueva hacia su vector local 'forward' (Se mueve hacia donde mira)
    /// </summary>
    private void FixedUpdate() {
        transform.position += velocidad * Time.fixedDeltaTime * transform.forward;
    }

    public void Atacar(SaludKart sk) {
        sk.salud -= daño;
        Destroy(gameObject);
    }

    
}
