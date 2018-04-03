using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letreros : MonoBehaviour //Este es solo un script que funcionara en caso que el jugador caiga en la primera trampa
{
    public GameObject letreroBurla; //Creamos el GameObject que se activará en caso que muera al principio

    private void Start() //Desactivamos en el arranque del juego
    {
        letreroBurla.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision) //Y si choca con la trampa se activara el cartel
    {
        if (collision.collider.CompareTag("Trap1"))
        {
            letreroBurla.SetActive(true);
        }
    }
}
