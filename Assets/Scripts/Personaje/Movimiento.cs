using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    float velocidad = 8.0f; //Definimos la velocidad, la rotación y el salto
    int giro = 200;         //Decimos que tipo de variable(En este caso int = entero)
    int salto = 5;          //Y le damos un valor, el modificador de acceso es privado
    bool estaEnPiso = false; //Esta variables nos sirve para controlar cuando puede o cuando no puede saltar
    public Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>(); //Le damos el componente a rb
    }

    void Update ()
    {
        float translation = Input.GetAxis("Vertical") * velocidad; //En las dos lineas siguientes es donde aplicamos la velocidad y rotacion para mover el personaje
        float rotation = Input.GetAxis("Horizontal") * giro;

        translation *= Time.deltaTime; //Estas dos lineas hace que el movimiento se vea lo mas fluido posibe independiente del PC
        rotation *= Time.deltaTime;
        
        transform.Translate(0, 0, translation); //Aquí decimos si queremos ejecutar en X, Y o Z (En este caso en Z)
        transform.Rotate(0, rotation, 0);       //Aquí decimos si queremos ejecutar en X, Y o Z (En este caso en Y)
    }

    void FixedUpdate() //En esta función verificamos la condición para saber si se puede o no agragar fuerza para el salto
    {
        if(Input.GetButtonDown("Jump") && estaEnPiso == true)
        {
            rb.AddForce(0, salto, 0, ForceMode.Impulse);
        }
    }

    void OnCollisionStay(Collision colision) //En los dos siguientes metodos es donde verificamos si esta o no en el suelo, y sea cual sea la respuesta se mandará al "FixedUpdate"
    {
        if (colision.collider.CompareTag("Piso"))
        {
            estaEnPiso = true;
        }
    }

    void OnCollisionExit(Collision caso)
    {
        if (caso.collider.CompareTag("Piso"))
        {
            estaEnPiso = false;
        }    
    }
}
