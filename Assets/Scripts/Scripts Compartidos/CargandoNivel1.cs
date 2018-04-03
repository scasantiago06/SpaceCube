using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargandoNivel1 : MonoBehaviour
{
    public Transform BarraEspera;
    public Transform TextProgreso;
    public Transform TextCargando;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;

    void Update()
    {
        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            TextProgreso.GetComponent<Text>().text = ((int)currentAmount).ToString() + "%";
            TextCargando.gameObject.SetActive(true);

        }
        else
        {
            TextCargando.gameObject.SetActive(false);
            TextProgreso.GetComponent<Text>().text = "Listo!";
            Application.LoadLevel("Nivel 1");
        }
        BarraEspera.GetComponent<Image>().fillAmount = currentAmount / 100;
    }
}
