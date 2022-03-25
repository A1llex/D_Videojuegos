using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    // Start is called before the first frame update
    public bool derecha = true;

    public float velocidad = 2f;

    public float dismax = 40f;

    [SerializeField]
    private bool choca = false;
    private Vector3 posinicio;
    void Start() {
        posinicio = transform.position; 
     }

    void Update() { 
        if (!choca){
            StartCoroutine(BalaMov());
        }
    }

    public IEnumerator BalaMov() {
        
        if (derecha && !choca)
        {
            transform.position += transform.right * velocidad * Time.deltaTime;
        }else if(!choca)
        {
            transform.position -= transform.right * velocidad * Time.deltaTime;
        }
        if (Vector3.Distance(posinicio, transform.position) > dismax) {
            gameObject.GetComponent<Animator>().SetTrigger("chocando");
            yield return new WaitForSeconds(1);
            Destroy(this.gameObject);
        }
     }

    private IEnumerator OnTriggerEnter2D() {
        choca = true;
        gameObject.GetComponent<Animator>().SetTrigger("chocando");
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
