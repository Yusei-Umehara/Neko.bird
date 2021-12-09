using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;


    public ControladorEscena controladorEscena; 
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            rb.velocity = Vector2.up * velocity;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        controladorEscena.Perdiste();
    }

    //if personaje esta en scene del menu, rigid body = false; else true.

}
