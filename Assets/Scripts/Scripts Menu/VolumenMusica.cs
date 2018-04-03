using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumenMusica : MonoBehaviour //Este script gestiona el volumen de la musica
{
    public Slider volumenMusica; //Creamos una variable slider que podremos mover para modificar el volumen

    public AudioSource musica; //Y esta AudioSource nos indicara cual es la musica que podemos modificar

    int counter = 1;
    float resultado;

    public void CambiarVolumen() //En esta funcion especificamos que la musica del AudioSource sera igual a la barra de slider para poder modificarla desde este objeto
    {
        musica.volume = volumenMusica.value;
    }

    public void MuteMusic() //Y esta funcion es para directamente quitar todo el volumen, o ponerlo todo
    {
        resultado = counter % 2;

        if (resultado == 1)
        {
            volumenMusica.value = 0;
        }
        else
        {
            volumenMusica.value = 1;
        }

        counter++;
        
    }
}
