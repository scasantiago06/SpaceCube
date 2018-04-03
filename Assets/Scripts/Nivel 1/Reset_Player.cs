using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Player : MonoBehaviour
{
    public GameObject Trap1;
    public Renderer rend; //Creamos esta variable Render para hacer parecer que el personaje desaparece cuando muera
    public bool scriptMove; //Y un bool que nos sirva para activar y desactivar un script
    public GameObject sensor;

    private void Start() //En este Start le damos el componente Render a la variable "rend"
    {
        rend = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other) //En el Trigger verificamos que si toca al objeto con este tag, primero se activa la trampa y luego empezamos la corrutina
    {
        if (other.CompareTag("Reset"))
        {
            Trap1.SetActive(true);
            StartCoroutine("DesactiveTrap1");
        }
        if (other.CompareTag("Traps")) //Y con este if, desactivamos el render cada que toque un objeto con este tag, a la vez que empiza la corrutina
        {
            rend.enabled = false;
            StartCoroutine("DesactiveTrap1");
        }
    }
    private void OnCollisionEnter(Collision collision) //En el Trigger verificamos que si toca al objeto con este tag,primero se desactiva el render y luego empezamos la corrutina
    {
        if (collision.collider.CompareTag("Trap1"))
        {
            rend.enabled = false;
            StartCoroutine("DesactiveTrap1");
        }
    }

    IEnumerator DesactiveTrap1()
    {
        scriptMove = GetComponent<Movimiento>().enabled = false; //Desactivamos el movimiento
        yield return new WaitForSeconds(1); //Esperamos un segundo
        Trap1.SetActive(false); //Volvemos a desactivar la trampa
        gameObject.transform.position = new Vector3(0, 2, 0); //Reubicamos al personaje
        gameObject.transform.rotation = new Quaternion(0, 20, 0,0);
        rend.enabled = true; //Activamos en Render
        scriptMove = GetComponent<Movimiento>().enabled = true; //Y activamos el movimiento
    }
}
