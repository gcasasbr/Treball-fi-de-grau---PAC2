using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Instruccions : MonoBehaviour
{

    public GameObject titol;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    public Scene scene;
    public string levelName;

    public int idiomaSeleccionat;

    
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        levelName = scene.name;


        titol = GameObject.Find("Titol");
        text1 = GameObject.Find("Objectiu");
        text2 = GameObject.Find("Temps");
        text3 = GameObject.Find("Moviments");

        idiomaSeleccionat = PlayerPrefs.GetInt("IdiomaSeleccionat");

        /*if (idiomaSeleccionat == null)
        {
            idiomaSeleccionat = 1;
        }
        */

    }

    // Update is called once per frame
    void Update()
    {
        if (levelName == "Scene46")
        {
            if (idiomaSeleccionat == 1) titol.GetComponent<Text>().text = "How to play";
            if (idiomaSeleccionat == 1) text1.GetComponent<Text>().text = "Get points by dragging your finger across the screen to make groupings of at least 3 fruits of the same type that are contiguous either horizontally, vertically, diagonally or a combination of them.";
            if (idiomaSeleccionat == 1) text2.GetComponent<Text>().text = "Each fruit gives 10 points.";
            if (idiomaSeleccionat == 1) text3.GetComponent<Text>().text = "Swap the positions of two different fruits either horizontally, vertically or diagonally.";


            if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Com jugar";
            if (idiomaSeleccionat == 2) text1.GetComponent<Text>().text = "Aconsegueix punts arrossegant el dit per la pantalla per realitzar agrupacions de com a mínim 3 fruites del mateix tipus que estiguin contigües ja sigui en horitzontal, vertical, diagonal o una convinació  d'elles.";
            if (idiomaSeleccionat == 2) text2.GetComponent<Text>().text = "Cada fruita otorga 10 punts.";
            if (idiomaSeleccionat == 2) text3.GetComponent<Text>().text = "Intercanvia les posicions de dos fruites diferents ja sigui en horitzonatal, vertical o diagonal.";

            if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Como jugar";
            if (idiomaSeleccionat == 3) text1.GetComponent<Text>().text = "Consigue puntos moviendo el dedo por la pantalla para realizar agrupaciones de como mínimo 3 frutas del mismo tipo que esten contiguas ya sea en horizontal, vertical, diagonal o una combinación de ellas.";
            if (idiomaSeleccionat == 3) text2.GetComponent<Text>().text = "Cada fruta otorga 10 puntos.";
            if (idiomaSeleccionat == 3) text3.GetComponent<Text>().text = "Intercambia las posiciones de dos frutas diferentes contiguas ya sea en horitzonatal, vertical o diagonal.";


        }

        if (levelName == "Scene47")
        {
            if (idiomaSeleccionat == 1) titol.GetComponent<Text>().text = "How to play";
            if (idiomaSeleccionat == 1) text1.GetComponent<Text>().text = "Special objects:";
            if (idiomaSeleccionat == 1) text2.GetComponent<Text>().text = "- Bomb: Destroy the fruits inside boxes that are the same type as the original fruits.";
            if (idiomaSeleccionat == 1) text3.GetComponent<Text>().text = "Add at the end of a group of at least two fruits of the same type, a special item in order to get special effects:";


            if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Com jugar";
            if (idiomaSeleccionat == 2) text1.GetComponent<Text>().text = "Objectes especials:";
            if (idiomaSeleccionat == 2) text2.GetComponent<Text>().text = "- Bomba: Destrueix les fruites dins de caixes que siguin del mateix tipus que les fruites originals.";
            if (idiomaSeleccionat == 2) text3.GetComponent<Text>().text = "Afegeix al final d'una agrupació de com a mínim dos fruites del mateix tipus un ítem especial a fi d'aconseguir efectes especials:";

            if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Como jugar";
            if (idiomaSeleccionat == 3) text1.GetComponent<Text>().text = "Objetos especiales:";
            if (idiomaSeleccionat == 3) text2.GetComponent<Text>().text = "- Bomba: Destruye las frutas dentro de cajas que sean del mismo tipo que las frutas originales.";
            if (idiomaSeleccionat == 3) text3.GetComponent<Text>().text = "Añade al final de una agrupación de como mínimo dos frutas del mismo tipo, un ítem especial a fin de conseguir efectos especiales:";


        }

        if (levelName == "Scene48")
        {
            if (idiomaSeleccionat == 1) titol.GetComponent<Text>().text = "How to play";
            if (idiomaSeleccionat == 1) text1.GetComponent<Text>().text = "Cherries: Multiply by two the points.";
            if (idiomaSeleccionat == 1) text2.GetComponent<Text>().text = "- Blue bubble: Subtract 50 points.";
            if (idiomaSeleccionat == 1) text3.GetComponent<Text>().text = "Blue Star: Eliminate all fruits from the line and award ten additional points. It can be swapped with any fruit.";


            if (idiomaSeleccionat == 2) titol.GetComponent<Text>().text = "Com jugar";
            if (idiomaSeleccionat == 2) text1.GetComponent<Text>().text = "- Cireres: Mutiplica per dos els punts.";
            if (idiomaSeleccionat == 2) text2.GetComponent<Text>().text = "- Bombolla blava: Resta 50 punts";
            if (idiomaSeleccionat == 2) text3.GetComponent<Text>().text = "- Estrella blava: Elimina totes les fruites de la linia i otorga 10 punts addicionals. Es pot intercanviar de posició amb qualsevol fruita.";

            if (idiomaSeleccionat == 3) titol.GetComponent<Text>().text = "Como jugar";
            if (idiomaSeleccionat == 3) text1.GetComponent<Text>().text = "- Cerezas: Mutiplica por dos los puntos";
            if (idiomaSeleccionat == 3) text2.GetComponent<Text>().text = "- Burbuja azul: Resta 50 puntos.";
            if (idiomaSeleccionat == 3) text3.GetComponent<Text>().text = "- Estrella azul: Elimina todas las frutas de la línea y otorga diez puntos adicionales. Se puede intercambiar de posición con cualquier fruta.";


        }

    }


    public void tornar()
    {
        if (levelName == "Scene46")
        {
            SceneManager.LoadScene(44);
        }

        if (levelName == "Scene47")
        {
            SceneManager.LoadScene(46);
        }

        if (levelName == "Scene48")
        {
            SceneManager.LoadScene(47);
        }
    }

    public void endavant()
    {
        if (levelName == "Scene46")
        {
            SceneManager.LoadScene(47);
        }

        if (levelName == "Scene47")
        {
            SceneManager.LoadScene(48);
        }

        if (levelName == "Scene48")
        {
            SceneManager.LoadScene(44);
        }

    }

}
