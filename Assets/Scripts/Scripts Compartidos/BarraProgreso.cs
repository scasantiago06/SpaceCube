using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class BarraProgreso : MonoBehaviour //Este scipt es igual al script con nombre "CargandoNivel1" y "CargandoNivel2", solo cambia la escena que carga cada uno
{
	public Transform BarraEspera;
	public Transform TextProgreso;
	public Transform TextCargando;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;
	
	void Update ()
    {
		if (currentAmount < 100)
        {
			currentAmount += speed * Time.deltaTime;
			TextProgreso.GetComponent<Text> ().text = ((int)currentAmount).ToString () + "%";
			TextCargando.gameObject.SetActive (true);

		}
        else
        {
			TextCargando.gameObject.SetActive (false);
			TextProgreso.GetComponent<Text> ().text = "Listo!";
			Application.LoadLevel( "Menu" );
		}
		BarraEspera.GetComponent<Image>().fillAmount = currentAmount / 100;
	}
}
