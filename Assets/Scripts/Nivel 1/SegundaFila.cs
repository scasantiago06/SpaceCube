using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundaFila : MonoBehaviour //Este Script es para hacer desaparecer unos planos que estan en la tercera fase del primer nivel
{
    public GameObject plano1; //Creamos los 3 GameObjects para almacenar los planos
    public GameObject plano2;
    public GameObject plano3;
    

    private void Start() //Damos paso a las corrutinas, que son las mismas solo que dan valores distintos para que cada plano actue distinto a los demas
    {
        StartCoroutine("Active_Desactive");
        StartCoroutine("Active_Desactive2");
        StartCoroutine("Active_Desactive3");
    }

    IEnumerator Active_Desactive() //Entramos en la corrutina
    {
        yield return new WaitForSeconds(Random.Range(2.5f,3)); //Esperamos un numero random de segundos
        plano1.SetActive(false); //Y se desactivara la plataforma
        yield return new WaitForSeconds(Random.Range(2,4)); //Luego esperamos otro numero random 
        plano1.SetActive(true); //Y vuelve y se activa
        StartCoroutine("Active_Desactive"); //Volvemos a empezar la corrutina, y este mismo proceso se hace con las demas corrutinas
    }

    IEnumerator Active_Desactive2()
    {
        yield return new WaitForSeconds(Random.Range(2, 2.5f));
        plano2.SetActive(false);
        yield return new WaitForSeconds(Random.Range(3, 4.5f));
        plano2.SetActive(true);
        StartCoroutine("Active_Desactive2");
    }

    IEnumerator Active_Desactive3()
    {
        yield return new WaitForSeconds(Random.Range(1.5f, 2.5f));
        plano3.SetActive(false);
        yield return new WaitForSeconds(Random.Range(2, 3));
        plano3.SetActive(true);
        StartCoroutine("Active_Desactive3");
    }
}
