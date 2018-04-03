using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour //Este script fue necesario para el nivel 2 ya que con la camara de siempre se hacia imposible pasar el nivel
{                                              //Asi que lo que hace este script es lo siguiente

    public Transform camaraPrincipal; //Al mover la camara lo que necesitamos es variables Transform, asi que esta primera almacenará la carmara principal del juego
    public Transform camaraNormal; //Esta variable contendra un Empty que estará en la posicion de la camara principal cuando se empieza el juego
    public Transform camaraVertical; //Y esta otra variable es otro empty que estara en la posicion dos que tendrá la camara principal

    private void OnTriggerEnter(Collider other) //Y simplemente verificamos con un OnTriggerEnter que si esta en la parte del mapa en donde se necesita cambiar de camara, que lo haga
    {
        if (other.CompareTag("CamaraVertical")) //Si toca el objeto con este tag cambiara a la posicion dos
        {
            camaraPrincipal.position = camaraVertical.position;
            camaraPrincipal.rotation = camaraVertical.rotation;
        }

        if (other.CompareTag("CamaraNormal")) //Y para volver a la posicion normal verificamos que toque otro objeto con un tag distinto y asi devolvera la camara a su posicion original
        {
            camaraPrincipal.position = camaraNormal.position;
            camaraPrincipal.rotation = camaraNormal.rotation;
        }
    }
}
