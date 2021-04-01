using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PantallaInici : MonoBehaviour
{

    public GameObject text1;
    public int idiomaSeleccionat;


    void Start()
    {

        idiomaSeleccionat = PlayerPrefs.GetInt("IdiomaSeleccionat");

        if (idiomaSeleccionat == null)
        {
            PlayerPrefs.SetInt("pantallaSeleccionada", 1);
            PlayerPrefs.SetInt("IdiomaSeleccionat", 1);
            PlayerPrefs.SetInt("pantallesPassades", 1);
            PlayerPrefs.SetInt("pantallesPassadesMon2", 1);
            PlayerPrefs.SetInt("pantallesPassadesMon3", 1);
            PlayerPrefs.SetInt("mon", 0);
        }

        if (idiomaSeleccionat != null)
        {
            if (idiomaSeleccionat == 1)
            {
                text1.GetComponent<Text>().text = "Tap to start";
            }

            if (idiomaSeleccionat == 2)
            {
                
                text1.GetComponent<Text>().text = "Pulsa per començar";
            }

            if (idiomaSeleccionat == 3)
            {
               
                
                text1.GetComponent<Text>().text = "Pulsa para empezar";
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            SceneManager.LoadScene(45);
        }


    }
}
