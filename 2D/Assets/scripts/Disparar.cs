using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    private bool flp = true;
    // Start is called before the first frame update
    void Start()
    {
    gameObject.GetComponent<SpriteRenderer>().flipX = flp;
    flp = !flp;
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetButtonDown("Fire1") )
        {
            Debug.Log("Disparo");
            //disparando = true;
            //shoot();
        }    
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

    
}
