using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasarNivel : MonoBehaviour //Este Script es solo para hacer que aparezca un boton cuando este en cierto lugar el cual servirá para pasar el nivel
{
    public GameObject boton; //Creamos el GameObject que nos servira para activarlo y desactivarlo

    private void Awake() //Aquí toco utilizar un Awake porque no entiendo que en el Start no estaba funcionando, pero es basicamente lo mismo
    {
        boton.SetActive(false); //Desactivo el boton al principio 
    }

    public void OnTriggerStay(Collider other) //Y en este Trigger verifico que si toca el objeto con este Tag se active el boton
    {
        if (other.CompareTag("Boton1"))
        {
            boton.SetActive(true);

        }
    }
}
