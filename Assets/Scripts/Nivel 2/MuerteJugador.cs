using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteJugador : MonoBehaviour //Con este script manejamos lo que pasa cuando el personaje "muere" en el segundo nivel
{
    public Renderer rend; //Creamos esta variable Render para hacer parecer que el personaje desaparece cuando muera
    public bool scriptMove; //Y un bool que nos sirva para activar y desactivar un script

    private void Start() //En este Start le damos el componente Render a la variable "rend"
    {
        rend = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other) //En el Trigger verificamos que si toca al objeto con este tag, primero se desactiva el render y luego empezamos la corrutina
    {
        if (other.CompareTag("Churiken"))
        {
            rend.enabled = false;
            StartCoroutine("DesactiveTrap1");
        }
    }

    IEnumerator DesactiveTrap1()
    {
        scriptMove = GetComponent<Movimiento>().enabled = false; //Primero desactivamos el script de movimiento para que parezca que esta muerto y no se mueva estando invisible
        yield return new WaitForSeconds(1); //Luego esperamos un segundo para que con las dos lineas que siguen reubiquen al jugador al inicio del mapa
        gameObject.transform.position = new Vector3(0, 2, 0);
        gameObject.transform.rotation = new Quaternion(0, 20, 0, 0);
        rend.enabled = true; //Y cuando esto suceda vuelva y active el Render para que el cubo se vuelva a ver
        scriptMove = GetComponent<Movimiento>().enabled = true; //Y active el movimiento 
    }
}

//Al principio se intento desactivando el objeto, pero claro, si estaba desactivado, no podia funcionar la corrutina que hacia que se volviera a activar
//La solucion era desde otro script activarlo, pero por orden y dejar todo en uno solo decidí hacerlo dentro de uno aplicando nuevas formas