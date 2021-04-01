using System.Collections;
using System.Collections.Generic;
using System.Globalization;
//using System.Security.Policy;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GUIController : MonoBehaviour

    {
    // Start is called before the first frame update

    public GameObject idioma_seleccionat;
    
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    

    public GameObject nuvol1;
    public GameObject nuvol2;
    public GameObject nuvol3;

    public GameObject objecteNodestruible;

    public Text hola;

    public int idiomaSeleccionat;
    public int pantalla;

   

    void Start()
    {

        //idioma_seleccionat = GameObject.Find("Idioma(Clone)");
        text1 = GameObject.Find("Play");
        text2 = GameObject.Find("IdiomaText");
        text3 = GameObject.Find("Exit");
        
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

        else
        {

            idiomaSeleccionat = PlayerPrefs.GetInt("IdiomaSeleccionat");
        }
        
      

        if (idiomaSeleccionat != null)
        {
            if (idiomaSeleccionat == 1)
            {
                text1.transform.GetChild(0).GetComponent<Text>().text = "Play";
                text2.transform.GetChild(0).GetComponent<Text>().text = "Language";
                text3.transform.GetChild(0).GetComponent<Text>().text = "Exit";
                text4.transform.GetChild(0).GetComponent<Text>().text = "How to play";
               
            }

            if (idiomaSeleccionat == 2)
            {
                text1.transform.GetChild(0).GetComponent<Text>().text = "Jugar";
                text2.transform.GetChild(0).GetComponent<Text>().text = "Idioma";
                text3.transform.GetChild(0).GetComponent<Text>().text = "Sortir";
                text4.transform.GetChild(0).GetComponent<Text>().text = "Com jugar";
               
            }

            if (idiomaSeleccionat == 3)
            {
                text1.transform.GetChild(0).GetComponent<Text>().text = "Jugar";
                text2.transform.GetChild(0).GetComponent<Text>().text = "Idioma";
                text3.transform.GetChild(0).GetComponent<Text>().text = "Salir";
                text4.transform.GetChild(0).GetComponent<Text>().text = "Como jugar";
               
            }
        }




    }


 
    // Update is called once per frame
    void Update()
    {
       
    }

    public void Opcions()
    {
        
        SceneManager.LoadScene(1);
    }

    public void Sortir()
    {
        Application.Quit();
    }

    public void Jugar()
    {
       SceneManager.LoadScene(7);
    }

    
    public void ComJugar()
    {

        SceneManager.LoadScene(46);
    }

}
