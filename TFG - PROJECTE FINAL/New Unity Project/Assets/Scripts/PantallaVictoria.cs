using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PantallaVictoria : MonoBehaviour
{

    public GameObject victoria;
    public GameObject victoria2;
    public GameObject idioma;
    public int idiomaSeleccionat;
    public int mon;
    public int pantallesPassades;

    public int pantallesPassadesMON1;
    public int pantallesPassadesMON2;

    public int pantallaSeleccionada;
    public int pantallaSeleccionadaMON1;
    public int pantallaSeleccionadaMON2;

    public Scene scene;
    public string levelName;

    public int disparador;

    
    void Start()
    {

       
        scene = SceneManager.GetActiveScene();
        levelName = scene.name;

        pantallaSeleccionada = PlayerPrefs.GetInt("pantallaSeleccionada");
        pantallaSeleccionadaMON1 = PlayerPrefs.GetInt("pantallaSeleccionadaMON1");
        pantallaSeleccionadaMON2 = PlayerPrefs.GetInt("pantallaSeleccionadaMON2");

        victoria = GameObject.Find("Text");
        victoria2 = GameObject.Find("Text2");
        idioma = GameObject.Find("Idioma(Clone)");
        idiomaSeleccionat = PlayerPrefs.GetInt("IdiomaSeleccionat");
        mon = PlayerPrefs.GetInt("mon");
        pantallesPassades= PlayerPrefs.GetInt("pantallesPassades");
        pantallesPassadesMON1 = PlayerPrefs.GetInt("pantallesPassadesMON1");
        pantallesPassadesMON2 = PlayerPrefs.GetInt("pantallesPassadesMON2");

        disparador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (levelName == "Scene 5")
        {
            if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) victoria.GetComponent<Text>().text = "VICTORY!!!";
            if (idiomaSeleccionat == 2) victoria.GetComponent<Text>().text = "VICTORIA!!!";
            if (idiomaSeleccionat == 3) victoria.GetComponent<Text>().text = "VICTORIA!!!";
        }

        if (levelName == "Scene6")
        {
            if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) victoria.GetComponent<Text>().text = "Ups...Time is over!!!";
            if (idiomaSeleccionat == 2) victoria.GetComponent<Text>().text = "Ups...El temps s'ha acabat!!!";
            if (idiomaSeleccionat == 3) victoria.GetComponent<Text>().text = "Ups...El tiempo se ha acabado!!!";
        }

       

    }

    public void tornar()
    {
        if (levelName == "Scene 5")
        {
                      
            
                if (pantallaSeleccionada > pantallesPassades || pantallesPassades == 1 || pantallaSeleccionada == pantallesPassades)
                {
                    if (pantallaSeleccionada == 1) PlayerPrefs.SetInt("pantallesPassades", 2);      //posar if per assegurar que pantalles passades sigui més petit que 8???
                    if (pantallaSeleccionada == 2) PlayerPrefs.SetInt("pantallesPassades", 3);
                    if (pantallaSeleccionada == 3) PlayerPrefs.SetInt("pantallesPassades", 4);
                    if (pantallaSeleccionada == 4) PlayerPrefs.SetInt("pantallesPassades", 5);
                    if (pantallaSeleccionada == 5) PlayerPrefs.SetInt("pantallesPassades", 6);
                    if (pantallaSeleccionada == 6) PlayerPrefs.SetInt("pantallesPassades", 7);
                    if (pantallaSeleccionada == 7) PlayerPrefs.SetInt("pantallesPassades", 8);
                    if (pantallaSeleccionada == 8) PlayerPrefs.SetInt("pantallesPassades", 9);
                    if (pantallaSeleccionada == 9)
                    {
                        PlayerPrefs.SetInt("mon", 1);
                        PlayerPrefs.SetInt("pantallesPassadesM1", 1);

                    }
                }
            

        }


        if (pantallaSeleccionada == 9 && levelName == "Scene 5")
        {
            SceneManager.LoadScene(7);
        }

        if (pantallaSeleccionada < 9 && levelName == "Scene 5")
        {
            SceneManager.LoadScene(3);
        }

                

        if (levelName == "Scene6")
        {
            SceneManager.LoadScene(3);

        }

        
    }

}
