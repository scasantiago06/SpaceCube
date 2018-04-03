using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeraFila : MonoBehaviour //Este script movera una de las plataformas de la tercera fase del primer nivel
{
    public Transform planoMove; //Creamos el Transform que es el que necesitamos que se mueva
    public GameObject target1; //Y un target al cual se dirigira la plataforma
    float speed = 0.1f; //Tambien creamos la velocidad que queremos

	void Start () //Empezamos la corrutina
    {
        StartCoroutine("MoviendoPlano");
	}


    IEnumerator MoviendoPlano() //Y lo que hace la corrutina es que el transform de la plataforma se mueva hacia el transform del target
    {
        for (float f = 25f; f >= 0; f -= 0.1f)
        {
            
            planoMove.transform.position = Vector3.MoveTowards(planoMove.transform.position, target1.transform.position, speed);
            yield return null;

            if (planoMove.transform.position == target1.transform.position) //Y cuando ambos sean iguales, la plataforma vuelva ala posicion inicial para que vuelva y se mueva hasta el fin del juego
            {
                planoMove.transform.position = new Vector3(63.02001f, -0.7599983f, 9.960015f);
                f = 25;
            }
            
        
        }
            
    }
}        
                  
	
