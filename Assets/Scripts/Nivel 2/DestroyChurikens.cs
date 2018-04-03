using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyChurikens : MonoBehaviour //Este script es simple, solo se queria destruir los Shurikens que ya no servian y estaban por todo el mapa
{
    private void OnTriggerEnter(Collider other) //Con este Trigger comparo si el Shuriken toca el objeto con este tag, y de ser asi, que destruya el Shuriken que es el que tiene este script
    {
        if (other.CompareTag("Destructor"))
        {
            Destroy(gameObject);
        }
    }
}
