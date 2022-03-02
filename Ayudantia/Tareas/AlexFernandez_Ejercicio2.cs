using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverDerecha : MonoBehaviour {

    public float velocidad;

    public int salud ;

    /// <summary>
    /// Cuanto tiempo ha pasado desde que inicio el juego
    /// </summary>
    public float contadorTiempo;
    
    // Start is called before the first frame update
    void Start() {
        salud = 3;
        StartCoroutine(bajarvida());

    }

    public IEnumerator bajarvida(){
        //esperar un segundo

        if (Input.GetKeyDown(KeyCode.P)) {
            if (salud>0) {
                yield return new WaitForSeconds(1);
                salud--;
            }
        }
        
    }

    // Update is called once per frame
    void Update() {
        // Se suma al contador el tiempo que ha pasado entre el cuadro
        // anterior y el actual (Time.deltaTime)
        contadorTiempo += Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) {
            gameObject.transform.position += Vector3.right * Time.deltaTime * velocidad;
        }

        
    }
}