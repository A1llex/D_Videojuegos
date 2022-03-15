using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    public int salud;

    private Animator _animador;

    private void Start() {
        _animador = GetComponent<Animator>();
    }

    public void RecibeDaño(int cantidad) {
        this.salud -=cantidad;
        if (salud > 0){
            _animador.SetTrigger("Hit");
        }else
        {
            _animador.SetBool("Muerte",true);
        }
    }
}
