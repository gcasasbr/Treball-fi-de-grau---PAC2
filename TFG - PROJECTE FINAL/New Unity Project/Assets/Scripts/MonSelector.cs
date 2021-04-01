using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MonSelector : MonoBehaviour
{

    public int idioma_seleccionat;
    public int mon;

    public GameObject titol;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    public GameObject boto2;
    public GameObject boto3;



    
    void Start()
    {

        idioma_seleccionat = PlayerPrefs.GetInt("IdiomaSeleccionat");
        mon = PlayerPrefs.GetInt("mon");

        titol = GameObject.Find("Titol");
        text1 = GameObject.Find("TextAire");
        text2 = GameObject.Find("TextFoc");
        text3 = GameObject.Find("TextAigua");

        boto3 = GameObject.Find("Foc");
        boto2 = GameObject.Find("Aigua");

        if (idioma_seleccionat == 1)
        {
            titol.GetComponent<Text>().text = "CHOOSE A MAP:";
            text1.GetComponent<Text>().text = "Day";
            text2.GetComponent<Text>().text = "Sunset";
            text3.GetComponent<Text>().text = "Night";
        }
        else
        {

            if (idioma_seleccionat == 2)
            {
                titol.GetComponent<Text>().text = "TRIA UN MAPA:";
                text1.GetComponent<Text>().text = "Dia";
                text2.GetComponent<Text>().text = "Posta de sol";
                text3.GetComponent<Text>().text = "Nit";

            }
            else
            {

                if (idioma_seleccionat == 3)
                {
                    titol.GetComponent<Text>().text = "ESCOGE UN MAPA:";
                    text1.GetComponent<Text>().text = "Dia";
                    text2.GetComponent<Text>().text = "Atardecer";
                    text3.GetComponent<Text>().text = "Noche";

                }
                else
                {
                    titol.GetComponent<Text>().text = "CHOOSE A MAP:";
                    text1.GetComponent<Text>().text = "Day";
                    text2.GetComponent<Text>().text = "Sunset";
                    text3.GetComponent<Text>().text = "Night";
                }
            }
        }


        if (mon == 1)
        {
            boto3.GetComponent<Button>().enabled = true;
            boto3.transform.GetChild(0).gameObject.SetActive(false);
            boto2.GetComponent<Button>().enabled = false;
            boto2.transform.GetChild(0).gameObject.SetActive(true);

        }

        if (mon == 2)
        {
            boto3.GetComponent<Button>().enabled = true;
            boto3.transform.GetChild(0).gameObject.SetActive(false);
            boto2.GetComponent<Button>().enabled = true;
            boto2.transform.GetChild(0).gameObject.SetActive(false);
        }



    }

    // Update is called once per frame
    void Update()
    {
        


    }


    public void Mon1()
    {
        SceneManager.LoadScene(3);
    }

    public void Mon2()
    {
        SceneManager.LoadScene(16);
    }

    public void Mon3()
    {
        SceneManager.LoadScene(30);
    }

    public void tronar()
    {
        SceneManager.LoadScene(44);
    }

}
