using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour{

    public float fuerzasalto = 400f;
    public bool saltando = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime,0));
            gameObject.GetComponent<Animator>().SetBool("moviendose",true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime,0));
            gameObject.GetComponent<Animator>().SetBool("moviendose",true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (!Input.GetKey("right") && !Input.GetKey("left"))
        {
            gameObject.GetComponent<Animator>().SetBool("moviendose",false);
        }
        

        if (Input.GetKeyDown("up") && !saltando)
        {
            saltando = true;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,fuerzasalto));
        }

     
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "suelo")
        {
            saltando = false;
        }
        
    }
}
