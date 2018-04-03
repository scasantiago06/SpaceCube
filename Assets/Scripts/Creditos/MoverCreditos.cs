using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoverCreditos : MonoBehaviour //Este script tiene como función hacer que el texto se desplace y simular los créditos
{
    public GameObject texto; //Primero declaro una variable GameObject a la cual le llenará con un cubo invisible y este será el padre del texto
    public GameObject target; //Esta otra variable GameIbject la usaremos como el objetivo al cual llegará el otro cubo que contiene el texto
    float speed = 5; //Y por último, esta variable la utilizaremos para darle velocidad al desplazamiento

    void Start () //En este Start solo decimos que empiece la corrutina 
    {
        StartCoroutine("Creditos");	
	}

    IEnumerator Creditos() //Y en esta corrutina decimos lo siguiente
    {
        for (float f = 125f; f >= 0; f -= 0.1f) //Creamos una variable que nos maneje un limite, para que no vaya a ser infinito ya que nos puede dar problemas
        {

            texto.transform.position = Vector3.MoveTowards(texto.transform.position, target.transform.position, speed); //En esta linea decimos que el transform de "texto" se movera a la posicion del "target" a una velocidad
            yield return null;

            if (texto.transform.position == target.transform.position) //Y con esta condición solo hacemos que cargue el "Menu" cuando la corrutina termine
            {
                SceneManager.LoadScene("Menu");
            }


        }
    }
}
