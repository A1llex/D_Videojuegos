using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour {

    public AudioClip sonidoExplosión;

    public float tiempoExplosión;

    private void Start() {
        StartCoroutine(ExplotaLuegoDe(tiempoExplosión));
    }

    public IEnumerator ExplotaLuegoDe(float t) {
        yield return new WaitForSeconds(t);
        Explotar();
    }

    public void Explotar() {
        GetComponent<AudioSource>().PlayOneShot(sonidoExplosión);
    }
}
