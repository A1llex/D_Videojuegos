using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorInteraccionables : MonoBehaviour {

    public Interaccionable ultimoInteraccionable;

    // Update is called once per frame
    void Update() {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) {
            if (hit.collider.TryGetComponent(out Interaccionable i)) {
                i.Delinear();
            }   
        }
    }
}
