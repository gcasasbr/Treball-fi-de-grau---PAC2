using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IdiomaSelector : MonoBehaviour
{

    public int idioma;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    public Scene scene;
    public string levelName;

    public int idioma_seleccionat;

    
    void Start()
    {

        

        text1 = GameObject.Find("Angles");
        text2 = GameObject.Find("Catala");
        text3 = GameObject.Find("Castella");

                
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        levelName = scene.name;

        idioma_seleccionat = PlayerPrefs.GetInt("IdiomaSeleccionat");

        if (levelName == "Scene1")
        {

            if (idioma_seleccionat == 1) text1.GetComponent<Text>().text = "English";
            if (idioma_seleccionat == 1) text2.GetComponent<Text>().text = "Catalan";
            if (idioma_seleccionat == 1) text3.GetComponent<Text>().text = "Spanish";

            if (idioma_seleccionat == 2) text1.GetComponent<Text>().text = "Inglès";
            if (idioma_seleccionat == 2) text2.GetComponent<Text>().text = "Català";
            if (idioma_seleccionat == 2) text3.GetComponent<Text>().text = "Castellà";

            if (idioma_seleccionat == 3) text1.GetComponent<Text>().text = "Inglés";
            if (idioma_seleccionat == 3) text2.GetComponent<Text>().text = "Catalán";
            if (idioma_seleccionat == 3) text3.GetComponent<Text>().text = "Castellano";
        }
        
    }

    public void SeleccioCatala()
    {
        PlayerPrefs.SetInt("IdiomaSeleccionat", 2);
    }

    public void SeleccioAngles()
    {
        PlayerPrefs.SetInt("IdiomaSeleccionat", 1); 
    }

    public void SeleccioCastella()
    {
        PlayerPrefs.SetInt("IdiomaSeleccionat", 3);
    }

    public void tornar()
    {
        SceneManager.LoadScene(44);
    }
}
