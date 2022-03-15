using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour {

    public Transform target;

    public Transform boquilla;

    /// <summary>
    /// Distancia a partir de la cual la torreta dispara al jugador 
    /// </summary>
    public float distanciaDisparo;

    /// <summary>
    /// Tiempo que debe pasar entre cada disparo
    /// </summary>
    public float tiempoEntreDisparos;

    public bool puedeDisparar;

    public GameObject prefabBala;

    private void Update() {
        // Completar: Si la distancia de la torreta al objetivo es menor a la
        // distancia de disparo y la torreta puede disparar, diparar al objetivo
        if (ObjetivoCerca() && puedeDisparar)
        {
            Disparar();
        }
    }

    /// <summary>
    /// Esta parte hace que la torreta mire hacia donde está el jugador
    /// </summary>
    private void FixedUpdate() {
        if ( target) {
            Vector3 directionToTarget = target.position - transform.position;
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.LookRotation(directionToTarget),Time.deltaTime);
        }
    }

    public bool ObjetivoCerca() {
        // Completar: Determinar si el objetivo está suficientemente cerca.
        // Hint : Usar Vector3.Distance 
        var distancia = Vector3.Distance(transform.position, target.position);
        if ( distanciaDisparo < distancia){
            transform.rotation = Quaternion.Euler(0,90,0);
        }
        return distancia < distanciaDisparo;
    } 

    public void Disparar() {
        // Completar: Instanciar un proyectil, aplicarle la rotación objetivo y
        // bloquear el disparo del arma por  el tiempo entre disparos.
        // Consultar el script InstanciaBonificador para pistas sobre como
        // instanciar objetos.
        Quaternion rotacionObjetivo = Quaternion.LookRotation(
            target.position - transform.position
        );
        if (this.prefabBala != null)
        {
            Instantiate(this.prefabBala, boquilla.position, rotacionObjetivo);
            StartCoroutine(BloquearDisparo(tiempoEntreDisparos));
        }
    }
    
    /// <summary>
    /// Rcuerde que para usar corutinas se necesita usar StartCoroutine.
    /// </summary>
    /// <param name="tiempo"></param>
    /// <returns></returns>
    public IEnumerator BloquearDisparo(float tiempo) {
        // Completar: Bloquear el disparo del arma por el tiempo dado
        this.puedeDisparar = false;
        yield return new WaitForSeconds(tiempo);
        this.puedeDisparar = true;
    }
}
