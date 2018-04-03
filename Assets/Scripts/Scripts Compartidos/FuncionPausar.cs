using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionPausar : MonoBehaviour
{
    public GameObject menuPause;
    public GameObject panelConfiguraciones;
    public GameObject botonPause;

    public AudioSource alPresionarBoton; //Estas dos variables me gestionaran el sonido que reproduce el apretar un boton
    public AudioClip sonido;

    private void Start()
    {
        menuPause.SetActive(false);
        panelConfiguraciones.SetActive(false);
        alPresionarBoton.clip = sonido; //Aqui decimos que a la variable audioSource la añada el clip que se guardara el la variable sonido
    }

    public void PausarJuego() //Esta funcion mas las dos de mas abajo, son las que seran llamadas segun el boton que se presione
    {
        if (Time.timeScale == 1) //Esta lo que me dice es que cambie el timeScale al contrario del que este en el momento
        {
            alPresionarBoton.Play(); //Tambien que me reproduzca un clip
            Time.timeScale = 0;
            menuPause.SetActive(true);
            botonPause.SetActive(false);

        }
        else
        {
            alPresionarBoton.Play();
            Time.timeScale = 1;
            menuPause.SetActive(false);
            botonPause.SetActive(true);
        }
    }

    public void MenuConfiguraciones() //Esta funcion me desactivara el menu y abrira el panel de configuraciones
    {
        alPresionarBoton.Play();
        menuPause.SetActive(false);
        panelConfiguraciones.SetActive(true);
    }

    public void VolverAlMenu() //Y esta retornara al menu, desactivando el panel de comfiguraciones
    {
        alPresionarBoton.Play();
        panelConfiguraciones.SetActive(false);
        menuPause.SetActive(true);
    }
}
