using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverSceneUno : MonoBehaviour //Este es el script que esta sirviendo para cargar otra escena por medio de un boton
{
    public void VolverAlMenuPrincipal(string cargarEscena) //Solo creamos una funcion que reciba strings para cuando la agreguemos a un boton poder introducir el nombre del nivel que queremos cargar
    {
        SceneManager.LoadScene(cargarEscena);
    }
}
