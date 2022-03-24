using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaccionable : MonoBehaviour {
    
    public Outline outline;
    
    private void Update() {
            if (Input.GetKeyDown(KeyCode.E)) {
                Delinear();
            } else if (Input.GetKeyDown(KeyCode.Q)) {
                QuitarDelineado();
            }
        }
    
        public void Delinear() {
            if (!outline) {
                outline = gameObject.AddComponent<Outline>();
            
                outline.OutlineMode = Outline.Mode.OutlineAll;
                outline.OutlineColor = Color.yellow;
                outline.OutlineWidth = 5f;
            }
        }
    
        public void QuitarDelineado() {
            if (outline) {
                Destroy(outline);
            }
        }
}
