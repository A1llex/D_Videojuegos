using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daEspadazo : MonoBehaviour{


    public Animator animador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if (InpuntGeMouseButtonDown(0)){
            animador.SettTriger("Ataca",True);
        }
        
    }
}
