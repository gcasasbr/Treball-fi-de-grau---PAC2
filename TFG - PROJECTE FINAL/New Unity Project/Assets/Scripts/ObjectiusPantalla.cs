using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectiusPantalla : MonoBehaviour
{

    public GameObject titol;
    public GameObject puntuacio;
    public GameObject temps;
    public GameObject moviment;
    public GameObject objectiu;
    public GameObject objectiu1;
    public GameObject objectiu2;
    public GameObject objectiu3;
    public GameObject objectiu4;
    public GameObject objectiu5;
    public GameObject BotonGO;

    public GameObject idioma;
    public int idiomaSeleccionat;

    public int pantallaSeleccionada;
    public int pantallaSeleccionadaMON1;
    public int pantallaSeleccionadaMON2;

    public Scene scene;
    public string levelName;


    
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        levelName = scene.name;

        titol = GameObject.Find("Titol");
        
        puntuacio = GameObject.Find("Objectiu");
        objectiu1 = GameObject.Find("Objectiu1");
        objectiu2 = GameObject.Find("Objectiu2");
        objectiu3 = GameObject.Find("Objectiu3");
        objectiu4 = GameObject.Find("Objectiu4");
        objectiu5 = GameObject.Find("Objectiu5");

        moviment = GameObject.Find("Moviments");
        temps=GameObject.Find("Temps");
        BotonGO= GameObject.Find("Text");

        //idioma = GameObject.Find("Idioma(Clone)");
        idiomaSeleccionat = PlayerPrefs.GetInt("IdiomaSeleccionat");
        pantallaSeleccionada = PlayerPrefs.GetInt("pantallaSeleccionada");
        pantallaSeleccionadaMON1= PlayerPrefs.GetInt("pantallaSeleccionadaMON1");
        pantallaSeleccionadaMON2 = PlayerPrefs.GetInt("pantallaSeleccionadaMON2");
    }

    // Update is called once per frame
    void Update()
    {

        if (levelName == "Scene4")
        {

            if (pantallaSeleccionada == 1)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 1";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 150 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 5";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 90 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 1";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 150 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 5";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 90 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 1";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 150 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 5";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 90 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }

            if (pantallaSeleccionada == 2)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 2";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 200 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 10";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 120 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 2";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 200 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 10";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 120 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 2";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 200 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 10";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 120 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }

            if (pantallaSeleccionada == 3)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 3";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 200 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 120 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 3";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 200 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 120 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 3";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 200 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 120 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 4)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 4";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 150 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 150 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 4";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 150 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 150 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 4";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 150 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 150 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 5)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 5";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 200 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 12";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 150 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 5";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 200 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 12";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 150 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 5";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 200 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 12";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 150 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 6)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 6";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 300 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 300 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 6";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 300 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 300 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 6";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 300 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 300 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 7)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 7";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 400 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 300 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 7";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 400 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 300 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 7";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 400 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 300 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 8)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 8";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 220 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 350 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 8";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 220 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 350 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 8";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 220 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 350 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }


            if (pantallaSeleccionada == 9)
            {
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) titol.GetComponent<Text>().text = "Stage 9";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) puntuacio.GetComponent<Text>().text = "Get more than 150 points";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) moviment.GetComponent<Text>().text = "Movments allowed: 15";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) temps.GetComponent<Text>().text = "Max time: 400 seconds";
                if (idiomaSeleccionat == 1 || idiomaSeleccionat == 0) BotonGO.GetComponent<Text>().text = "GO!!!";


                if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Pantalla 9";
                if (idiomaSeleccionat == 2) puntuacio.GetComponent<Text>().text = "Aconsegueix més de 150 punts";
                if (idiomaSeleccionat == 2) moviment.GetComponent<Text>().text = "Moviments permesos: 15";
                if (idiomaSeleccionat == 2) temps.GetComponent<Text>().text = "Temps màxim: 400 segons";
                if (idiomaSeleccionat == 2) BotonGO.GetComponent<Text>().text = "Som-hi!!!";


                if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Pantalla 9";
                if (idiomaSeleccionat == 3) puntuacio.GetComponent<Text>().text = "Consigue mas de 150 puntos";
                if (idiomaSeleccionat == 3) moviment.GetComponent<Text>().text = "Movimentos permitidos: 15";
                if (idiomaSeleccionat == 3) temps.GetComponent<Text>().text = "Tiempo máximo: 400 segundos";
                if (idiomaSeleccionat == 3) BotonGO.GetComponent<Text>().text = "Vamos!!!";
            }

        }

        
        


    }

    public void pantallaJugar()
    {

        if (levelName == "Scene4")
        {

            if (pantallaSeleccionada == 1) SceneManager.LoadScene(2);
            if (pantallaSeleccionada == 2) SceneManager.LoadScene(8);
            if (pantallaSeleccionada == 3) SceneManager.LoadScene(9);
            if (pantallaSeleccionada == 4) SceneManager.LoadScene(10);
            if (pantallaSeleccionada == 5) SceneManager.LoadScene(11);
            if (pantallaSeleccionada == 6) SceneManager.LoadScene(12);
            if (pantallaSeleccionada == 7) SceneManager.LoadScene(13);
            if (pantallaSeleccionada == 8) SceneManager.LoadScene(14);
            if (pantallaSeleccionada == 9) SceneManager.LoadScene(15);
        }

        
    }

    public void tornar()
    {
        if (levelName == "Scene4") SceneManager.LoadScene(3);
        
        
    }

}
