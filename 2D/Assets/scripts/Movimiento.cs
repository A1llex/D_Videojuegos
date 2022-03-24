using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Update is called once per frame
    public float fuerzasalto = 600f;
    public bool saltando = false;

    // public bool puedeDisparar;

    // [SerializeField]
    // public GameObject prefabBala;
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
            gameObject.GetComponent<Animator>().SetBool("corriendo",true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime,0));
            gameObject.GetComponent<Animator>().SetBool("corriendo",true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (!Input.GetKey("right") && !Input.GetKey("left"))
        {
            gameObject.GetComponent<Animator>().SetBool("corriendo",false);
        }
        

        if (Input.GetKeyDown("up") && !saltando)
        {
            saltando = true;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,fuerzasalto));
            gameObject.GetComponent<Animator>().SetBool("saltando",true);
        }
    
    }

    // private void shoot(){
    //     Instantiate(bala);
    // }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "suelo")
        {
            saltando = false;
            gameObject.GetComponent<Animator>().SetBool("saltando",false);
        }
        
    }
}
