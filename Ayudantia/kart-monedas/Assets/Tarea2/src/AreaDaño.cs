using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDaño : MonoBehaviour {

    public int daño;

    private void OnTriggerEnter(Collider other) {
        if (other.TryGetComponent(out Enemigo e)) {
            DañaEnemigo(e);
        }
    }

    public void DañaEnemigo(Enemigo e) {
        e.RecibeDaño(this.daño);
    }
}
