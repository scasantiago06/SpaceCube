using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton1eraTrampa : MonoBehaviour //Este script se hizo para poder desactivar la primera trampa que esta escondida
{
    public GameObject Boton; //Este es el boton que desactivara la trampa
    public GameObject sensor; //Este sensor es el que nos dira cuando podemos tocar el boton
    public GameObject texto; //Y este texto solo es para agregar una ayuda cuando aparezca el boton

    private void Start() //Al principio el boton y el texto estarán desactivados
    {
        Boton.SetActive(false);
        texto.SetActive(false);
    }
    private void OnTriggerStay(Collider other) //Y si el objeto que tiene el script entra en contacto con el jugador, se activa el boton y el texto
    {
        if (other.CompareTag("Player"))
        {
            Boton.SetActive(true);
            texto.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other) //Y si dejan de tocarse, vuelven y se desactivan
    {
        if (other.CompareTag("Player"))
        {
            Boton.SetActive(false);
            texto.SetActive(false);
        }
    }

    public void DesactivarTrampa() //Y esta funcion sera llamada en el "On Clic" del boton, al momento de presionarlo, desactive el sensor que activa la trampa
    {
        sensor.SetActive(false);
    }
}
