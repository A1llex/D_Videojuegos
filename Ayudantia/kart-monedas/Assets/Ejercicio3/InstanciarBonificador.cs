using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarBonificador : MonoBehaviour{

    public GameObject prefabBonificador;

    // Start is called before the first frame update
    void Start(){
	    Instantiate(prefabBonificador, transform.position + Vector3.up * 2f, Quaternion.identity);       
    }
}
