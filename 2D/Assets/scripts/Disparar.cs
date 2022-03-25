using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Transform posinicio;
    public float tiempoEntreDisparos;
    public bool puedeDisparar = true;
    public GameObject prefabBala;
    private bool flp ;
    // Start is called before the first frame update
    void Start()
    {
        posinicio = transform;
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetButtonDown("Fire1") )
        {
            if (puedeDisparar && this.prefabBala != null)
            {
                Debug.Log("dispara");
                flp = gameObject.GetComponent<SpriteRenderer>().flipX;
                GameObject g = Instantiate(this.prefabBala, (posinicio.position+ 2*(Vector3.right*(flp ? 1 : -1)) ),Quaternion.identity);
                g.GetComponent<Bala>().derecha = flp;
                StartCoroutine(BloquearDisparo(tiempoEntreDisparos));
            }
        }    
    }

    public IEnumerator BloquearDisparo(float tiempo) {
        // Completar: Bloquear el disparo del arma por el tiempo dado
        this.puedeDisparar = false;
        yield return new WaitForSeconds(tiempo);
        this.puedeDisparar = true;
    }

    
}
