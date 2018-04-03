using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarNivel2 : MonoBehaviour //Este script es para cuando llegue al final del primer nivel, se active un boton para pasar al segundo nivel
{
    public GameObject botonCargar; //Aqui almacenaremos el boton con el que cargaremos la escena siguiente

    private void Start() //Desactivamos el boton al principio
    {
        botonCargar.SetActive(false);
    }

    void OnTriggerEnter(Collider other) //Con los siguientes Trigger verificamos que si esta tocando se active el boton, o si no, se desactive
    {
        if (other.CompareTag("Player"))
        {
            botonCargar.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            botonCargar.SetActive(false);
        }
    }

    public void CargarSegundoNivel(string nombreDelNivel) //Y esta es la funcion que agregamos al boton para cargar la otra escena
    {
        SceneManager.LoadScene(nombreDelNivel);
    }
}
