using System;
using System.Collections;
using System.Collections.Generic;
using KartGame.KartSystems;
using UnityEngine;

public class BonusVelocidad : MonoBehaviour {

    public float bonusAVelocidad;

    public float duración;

    private void OnTriggerEnter(Collider other) {
        Bonificar(other.gameObject);
        Debug.Log(other.gameObject);
    }

    public void Bonificar(GameObject objetoABonificar) {
        ArcadeKart kart = objetoABonificar.GetComponent<ArcadeKart>();
        GetComponent<AudioSource>().Play();
        if (kart != null) {
            StartCoroutine(AumentaVelocidad(kart));
       
}
    }

    public IEnumerator AumentaVelocidad(ArcadeKart kart) {
        kart.baseStats.TopSpeed += bonusAVelocidad;
        yield return new WaitForSeconds(duración);
        kart.baseStats.TopSpeed -= bonusAVelocidad;
    }
}