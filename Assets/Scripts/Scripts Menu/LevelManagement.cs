using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagement : MonoBehaviour
{
    public GameObject panelPrincipal;
    public GameObject panelConfiguraciones;
    public GameObject panelEleccion;

    public AudioSource pressButtom;
    public AudioClip sonido;

    private void Start()
    {
        panelEleccion.SetActive(false);
        panelConfiguraciones.SetActive(false);
        pressButtom.clip = sonido;
    }

    public void CargaNivel(string nombreDelNivel) //Todas las funciones de aqui hacia abajo seran activadas dependiendo del boton presionado en el menu principal
    {
        pressButtom.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(nombreDelNivel);
    }

    public void CargarOpciones() //Aqui cargamos un panel en donde se nos muestra las opciones que tenemos
    {
        pressButtom.Play();
        panelPrincipal.SetActive(false);
        panelConfiguraciones.SetActive(true);
    }

    public void VolverMenuPrincipal() //En esta volvemos al panel que tiene menu del inicio
    {
        pressButtom.Play();
        panelPrincipal.SetActive(true);
        panelConfiguraciones.SetActive(false);
        panelEleccion.SetActive(false);
    }

    public void EleccionNivel() //Esta funcion desplegara un panel que nos indique que nivel queremos jugar
    {
        panelPrincipal.SetActive(false);
        panelEleccion.SetActive(true);
    }

    public void SalirJuego() //Esta es la funcion que cuando sea llamada quitará el juego
    {
        Application.Quit();
    }
}
