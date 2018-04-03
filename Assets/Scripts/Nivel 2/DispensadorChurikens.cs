using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispensadorChurikens : MonoBehaviour //Este script es el que sirvio para la trampa del segundo nivel, que era disparar Shurikens
{

    public Rigidbody rocket; //La variable Rigidbody es para despues poder clonar el objeto que se almacene en esta variable
    float speed; //esta sera la velocidad con la que sera instanciado el objeto
    public Transform[] targets1; //Y como este script lo tiene un Empty toco hacer dos Arrays para almacenar los objetos de los cuales seran disparados los Shurikens
    public Transform[] targets2; 

    private void Start() //Solo estoy diciendo que empiecen las corrutinas
    {
        StartCoroutine("FireChuriken");
        StartCoroutine("FireChuriken2");
    }

    IEnumerator FireChuriken() //Ambas corrutinas son exactamente iguales, solo que con una estoy gestionando uno de los Arrays y con la otra el que sobra, esto fue hecho por tener mejor orden
    {
        yield return new WaitForSeconds(Random.Range(1.5f ,3.5f)); //Aqui estoy diciendo que espere ciertos segundos que pueden variar ya que es Random.Range, para que empiece la corrutina

        for (int f = 0; f < targets1.Length; f++) //Aqui especificamos que cantidad de veces se repetirá este "For", en este caso será la longitud del Array
        {
            speed = Random.Range(10, 15); //La velocidad la definimos Random para que varie
            Rigidbody rocketClone = Instantiate(rocket, targets1[f].transform.position, transform.rotation); //Y en esta linea es donde estamos instanciando un Clon del Rigidbody original creado al principio del código
            rocketClone.velocity = transform.forward * speed; //Y luego le agregamos la variable speed definida anteriormente para que la instancia se pueda mover
        }
        StartCoroutine("FireChuriken"); //Por último decimos que vuelva y empiece la corrutina
    }

    IEnumerator FireChuriken2()
    {
        yield return new WaitForSeconds(Random.Range(2, 2.5f));

        for (int y = 0; y < targets2.Length; y++)
        {
            speed = Random.Range(7, 12);
            Rigidbody rocketClone2 = Instantiate(rocket, targets2[y].transform.position, transform.rotation);
            rocketClone2.velocity = transform.forward * speed;
        }
        StartCoroutine("FireChuriken2");
    }
}

//Aqui me surgio un problema y era que al objeto que le agregue este script tenia la posicion Z en donde no queria que estuviera, es decir,
//siempre que me instaciaba un objeto, me lo tiraba hacia la Z de este objeto que tenia el script, y no se veia bien porque el orificio
//estaba en X, osea que el objeto que instanciaba salia por un lateral, es como si trataras de tirar un balon hacia de frente pero al final
//salia hacia un lado, no tiene sentido, asi que cree un Empty y coloque la Z hacia donde queria, y luego al script le dije que lo que va a 
//instanciar, lo hiciera en otro GameObject, asi que lo que hacia era, instaciar el objeto teniendo como referencia el transform del empty
//pero lo istanciaba en otro objeto
