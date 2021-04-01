using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour
{

    

    public GameObject text1;
    public int idiomaSeleccionat;

    
    void Start()
    {

        idiomaSeleccionat = PlayerPrefs.GetInt("IdiomaSeleccionat");

        if (idiomaSeleccionat != null)
        {
            if (idiomaSeleccionat == 1)
            {
                text1.GetComponent<Text>().text = "LOADING...";
            }

            if (idiomaSeleccionat == 2)
            {

                text1.GetComponent<Text>().text = "CARREGANT...";
            }

            if (idiomaSeleccionat == 3)
            {


                text1.GetComponent<Text>().text = "CARGANDO...";
            }
        }

        Invoke("Cargar", 2f);

    }


    void Cargar()
    {
        SceneManager.LoadScene(44);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
