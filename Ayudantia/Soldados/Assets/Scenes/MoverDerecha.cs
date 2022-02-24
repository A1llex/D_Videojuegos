using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverDerecha : MonoBehaviour
{
    public float velocidad = 1;
    public float contadorTiempo;
    public float vida = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //contadorTiempo += contadorTiempo + Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.D)){
            gameObject.transform.position += Vector3.right * Time.deltaTime * velocidad;
        }

        if(Input.GetKeyDown(KeyCode.P)){
            vida -= 1;
        }
    }
}
