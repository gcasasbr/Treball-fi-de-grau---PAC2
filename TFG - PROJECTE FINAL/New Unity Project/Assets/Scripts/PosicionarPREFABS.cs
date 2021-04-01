using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PosicionarPREFABS : MonoBehaviour
{
    
    public Vector3 posicioX1Y1;
    public Vector3 posicioX1Y2;
    public Vector3 posicioX1Y3;
    public Vector3 posicioX1Y4;
    public Vector3 posicioX1Y5;
    public Vector3 posicioX1Y6;
    public Vector3 posicioX1Y7;
    public Vector3 posicioX1Y8;
    public Vector3 posicioX1Y9;

    public Vector3 posicioX2Y1;
    public Vector3 posicioX2Y2;
    public Vector3 posicioX2Y3;
    public Vector3 posicioX2Y4;
    public Vector3 posicioX2Y5;
    public Vector3 posicioX2Y6;
    public Vector3 posicioX2Y7;
    public Vector3 posicioX2Y8;
    public Vector3 posicioX2Y9;

    public Vector3 posicioX3Y1;
    public Vector3 posicioX3Y2;
    public Vector3 posicioX3Y3;
    public Vector3 posicioX3Y4;
    public Vector3 posicioX3Y5;
    public Vector3 posicioX3Y6;
    public Vector3 posicioX3Y7;
    public Vector3 posicioX3Y8;
    public Vector3 posicioX3Y9;

    public Vector3 posicioX4Y1;
    public Vector3 posicioX4Y2;
    public Vector3 posicioX4Y3;
    public Vector3 posicioX4Y4;
    public Vector3 posicioX4Y5;
    public Vector3 posicioX4Y6;
    public Vector3 posicioX4Y7;
    public Vector3 posicioX4Y8;
    public Vector3 posicioX4Y9;

    public Vector3 posicioX5Y1;
    public Vector3 posicioX5Y2;
    public Vector3 posicioX5Y3;
    public Vector3 posicioX5Y4;
    public Vector3 posicioX5Y5;
    public Vector3 posicioX5Y6;
    public Vector3 posicioX5Y7;
    public Vector3 posicioX5Y8;
    public Vector3 posicioX5Y9;


    public GameObject Taronja;
    public GameObject Tomaquet;
    public GameObject Fresa;
    public GameObject Llimona;
    public GameObject Melo;

    public GameObject EstrellaBlava;
    public GameObject BombollaBlava;
    public GameObject Bomba;
    public GameObject Cireres;

    public GameObject Caixa;
    
    public GameObject taronjaTancada;
    public GameObject tomaquetTancat;
    public GameObject meloTancat;
    public GameObject llimonaTancada;

    public Scene sceneActual;
    public string NomEscena;


    void Start()
    {

        
        posicioX1Y1 = new Vector3(-1.674597f, 3.63f, 12.4998f);
        posicioX1Y2 = new Vector3(-1.674597f, 2.93f, 12.4998f); 
        posicioX1Y3 = new Vector3(-1.674597f, 2.28f, 12.4998f);
        posicioX1Y4 = new Vector3(-1.674597f, 1.6f, 12.4998f); 
        posicioX1Y5 = new Vector3(-1.674597f, 0.92f, 12.4998f);
        posicioX1Y6 = new Vector3(-1.674597f, 0.22f, 12.4998f);
        posicioX1Y7 = new Vector3(-1.674597f, -0.41f, 12.4998f);
        posicioX1Y8 = new Vector3(-1.674597f, -1.13f, 12.4998f);
        posicioX1Y9 = new Vector3(-1.674597f, -1.8f, 12.4998f);
        
        
        posicioX2Y1 = new Vector3(-0.8438f, 3.63f, 12.4998f);
        posicioX2Y2 = new Vector3(-0.8438f, 2.93f, 12.4998f);
        posicioX2Y3 = new Vector3(-0.8438f, 2.28f, 12.4998f);
        posicioX2Y4 = new Vector3(-0.8438f, 1.6f, 12.4998f);
        posicioX2Y5 = new Vector3(-0.8438f, 0.92f, 12.4998f);
        posicioX2Y6 = new Vector3(-0.8438f, 0.22f, 12.4998f);
        posicioX2Y7 = new Vector3(-0.8438f, -0.41f, 12.4998f);
        posicioX2Y8 = new Vector3(-0.8438f, -1.13f, 12.4998f);
        posicioX2Y9 = new Vector3(-0.8438f, -1.8f, 12.4998f);

        posicioX3Y1 = new Vector3(-0.0131f, 3.63f, 12.4998f);
        posicioX3Y2 = new Vector3(-0.0131f, 2.93f, 12.4998f);
        posicioX3Y3 = new Vector3(-0.0131f, 2.28f, 12.4998f);
        posicioX3Y4 = new Vector3(-0.0131f, 1.6f, 12.4998f);
        posicioX3Y5 = new Vector3(-0.0131f, 0.92f, 12.4998f);
        posicioX3Y6 = new Vector3(-0.0131f, 0.22f, 12.4998f);
        posicioX3Y7 = new Vector3(-0.0131f, -0.41f, 12.4998f);
        posicioX3Y8 = new Vector3(-0.0131f, -1.13f, 12.4998f);
        posicioX3Y9 = new Vector3(-0.0131f, -1.8f, 12.4998f);

        posicioX4Y1 = new Vector3(0.8176f, 3.63f, 12.4998f);
        posicioX4Y2 = new Vector3(0.8176f, 2.93f, 12.4998f);
        posicioX4Y3 = new Vector3(0.8176f, 2.28f, 12.4998f);
        posicioX4Y4 = new Vector3(0.8176f, 1.6f, 12.4998f);
        posicioX4Y5 = new Vector3(0.8176f, 0.92f, 12.4998f);
        posicioX4Y6 = new Vector3(0.8176f, 0.22f, 12.4998f);
        posicioX4Y7 = new Vector3(0.8176f, -0.41f, 12.4998f);
        posicioX4Y8 = new Vector3(0.8176f, -1.13f, 12.4998f);
        posicioX4Y9 = new Vector3(0.8176f, -1.8f, 12.4998f);

        posicioX5Y1 = new Vector3(1.6483f, 3.63f, 12.4998f);
        posicioX5Y2 = new Vector3(1.6483f, 2.93f, 12.4998f);
        posicioX5Y3 = new Vector3(1.6483f, 2.28f, 12.4998f);
        posicioX5Y4 = new Vector3(1.6483f, 1.6f, 12.4998f);
        posicioX5Y5 = new Vector3(1.6483f, 0.92f, 12.4998f);
        posicioX5Y6 = new Vector3(1.6483f, 0.22f, 12.4998f);
        posicioX5Y7 = new Vector3(1.6483f, -0.41f, 12.4998f);
        posicioX5Y8 = new Vector3(1.6483f, -1.13f, 12.4998f);
        posicioX5Y9 = new Vector3(1.6483f, -1.8f, 12.4998f);
                

        sceneActual = SceneManager.GetActiveScene();
        NomEscena = sceneActual.name;

        switch (NomEscena)
        {

        case "Scene2":

                Instantiate(Fresa, posicioX1Y1, Quaternion.identity);
                Instantiate(Taronja, posicioX1Y2, Quaternion.identity);
                Instantiate(Taronja, posicioX1Y3, Quaternion.identity);
                Instantiate(meloTancat, posicioX1Y4, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y5, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y6, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y7, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y8, Quaternion.identity);
                Instantiate(Cireres, posicioX1Y9, Quaternion.identity);
                
                Instantiate(tomaquetTancat, posicioX2Y1, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y2, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y3, Quaternion.identity);
                Instantiate(taronjaTancada, posicioX2Y4, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y5, Quaternion.identity);
                Instantiate(Tomaquet, posicioX2Y6, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y7, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y8, Quaternion.identity);
                Instantiate(Melo, posicioX2Y9, Quaternion.identity);

                Instantiate(Tomaquet, posicioX3Y1, Quaternion.identity);
                Instantiate(llimonaTancada, posicioX3Y2, Quaternion.identity);
                Instantiate(Melo, posicioX3Y3, Quaternion.identity);
                Instantiate(Tomaquet, posicioX3Y4, Quaternion.identity);
                Instantiate(llimonaTancada, posicioX3Y5, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y6, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y7, Quaternion.identity);
                Instantiate(Tomaquet, posicioX3Y8, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y9, Quaternion.identity);

                Instantiate(tomaquetTancat, posicioX4Y1, Quaternion.identity);
                Instantiate(Llimona, posicioX4Y2, Quaternion.identity);
                Instantiate(Llimona, posicioX4Y3, Quaternion.identity);
                Instantiate(Melo, posicioX4Y4, Quaternion.identity);
                Instantiate(Melo, posicioX4Y5, Quaternion.identity);
                Instantiate(Taronja, posicioX4Y6, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y7, Quaternion.identity);
                Instantiate(meloTancat, posicioX4Y8, Quaternion.identity);
                Instantiate(Taronja, posicioX4Y9, Quaternion.identity);

                Instantiate(Tomaquet, posicioX5Y1, Quaternion.identity);
                Instantiate(Taronja, posicioX5Y2, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX5Y3, Quaternion.identity);
                Instantiate(Taronja, posicioX5Y4, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y5, Quaternion.identity);
                Instantiate(Taronja, posicioX5Y6, Quaternion.identity);
                Instantiate(Taronja, posicioX5Y7, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y8, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX5Y9, Quaternion.identity);
                
                break;


         case "Scene8":

                Instantiate(Melo, posicioX1Y1, Quaternion.identity);
                Instantiate(Melo, posicioX1Y2, Quaternion.identity);
                Instantiate(Llimona, posicioX1Y3, Quaternion.identity);
                Instantiate(taronjaTancada, posicioX1Y4, Quaternion.identity);
                Instantiate(Caixa, posicioX1Y5, Quaternion.identity);
                Instantiate(Caixa, posicioX1Y6, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y7, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y8, Quaternion.identity);
                Instantiate(Taronja, posicioX1Y9, Quaternion.identity);

                Instantiate(Tomaquet, posicioX2Y1, Quaternion.identity);
                Instantiate(Fresa, posicioX2Y2, Quaternion.identity);
                Instantiate(Tomaquet, posicioX2Y3, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y4, Quaternion.identity);
                Instantiate(Caixa, posicioX2Y5, Quaternion.identity);
                Instantiate(Caixa, posicioX2Y6, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y7, Quaternion.identity);
                Instantiate(Tomaquet, posicioX2Y8, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y9, Quaternion.identity);

                Instantiate(Caixa, posicioX3Y1, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y2, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y3, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y4, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y5, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y6, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y7, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y8, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y9, Quaternion.identity);

                Instantiate(Llimona, posicioX4Y1, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y2, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y3, Quaternion.identity);
                Instantiate(Llimona, posicioX4Y4, Quaternion.identity);
                Instantiate(Caixa, posicioX4Y5, Quaternion.identity);
                Instantiate(Caixa, posicioX4Y6, Quaternion.identity);
                Instantiate(Melo, posicioX4Y7, Quaternion.identity);
                Instantiate(taronjaTancada, posicioX4Y8, Quaternion.identity);
                Instantiate(Melo, posicioX4Y9, Quaternion.identity);

                Instantiate(Llimona, posicioX5Y1, Quaternion.identity);
                Instantiate(Fresa, posicioX5Y2, Quaternion.identity);
                Instantiate(Fresa, posicioX5Y3, Quaternion.identity);
                Instantiate(Cireres, posicioX5Y4, Quaternion.identity);
                Instantiate(Caixa, posicioX5Y5, Quaternion.identity);
                Instantiate(Caixa, posicioX5Y6, Quaternion.identity);
                Instantiate(taronjaTancada, posicioX5Y7, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y8, Quaternion.identity);
                Instantiate(Melo, posicioX5Y9, Quaternion.identity);

                break;


            case "Scene9":

                Instantiate(Fresa, posicioX1Y1, Quaternion.identity);
                Instantiate(Taronja, posicioX1Y2, Quaternion.identity);
                Instantiate(Llimona, posicioX1Y3, Quaternion.identity);
                Instantiate(Llimona, posicioX1Y4, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y5, Quaternion.identity);
                Instantiate(Taronja, posicioX1Y6, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y7, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y8, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y9, Quaternion.identity);

                Instantiate(Fresa, posicioX2Y1, Quaternion.identity);
                Instantiate(meloTancat, posicioX2Y2, Quaternion.identity);
                Instantiate(Tomaquet, posicioX2Y3, Quaternion.identity);
                Instantiate(Fresa, posicioX2Y4, Quaternion.identity);
                Instantiate(Melo, posicioX2Y5, Quaternion.identity);
                Instantiate(Fresa, posicioX2Y6, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y7, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y8, Quaternion.identity);
                Instantiate(Melo, posicioX2Y9, Quaternion.identity);

                Instantiate(Fresa, posicioX3Y1, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y2, Quaternion.identity);
                Instantiate(Melo, posicioX3Y3, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y4, Quaternion.identity);
                Instantiate(Tomaquet, posicioX3Y5, Quaternion.identity);
                Instantiate(Tomaquet, posicioX3Y6, Quaternion.identity);
                Instantiate(meloTancat, posicioX3Y7, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y8, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y9, Quaternion.identity);

                Instantiate(Llimona, posicioX4Y1, Quaternion.identity);
                Instantiate(Tomaquet, posicioX4Y2, Quaternion.identity);
                Instantiate(Caixa, posicioX4Y3, Quaternion.identity);
                Instantiate(Tomaquet, posicioX4Y4, Quaternion.identity);
                Instantiate(meloTancat, posicioX4Y5, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y6, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX4Y7, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y8, Quaternion.identity);
                Instantiate(Tomaquet, posicioX4Y9, Quaternion.identity);

                Instantiate(Melo, posicioX5Y1, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y2, Quaternion.identity);
                Instantiate(Melo, posicioX5Y3, Quaternion.identity);
                Instantiate(Bomba, posicioX5Y4, Quaternion.identity);
                Instantiate(meloTancat, posicioX5Y5, Quaternion.identity);
                Instantiate(Caixa, posicioX5Y6, Quaternion.identity);
                Instantiate(Caixa, posicioX5Y7, Quaternion.identity);
                Instantiate(taronjaTancada, posicioX5Y8, Quaternion.identity);
                Instantiate(meloTancat, posicioX5Y9, Quaternion.identity);

                break;


            case "Scene10":

                Instantiate(tomaquetTancat, posicioX1Y1, Quaternion.identity);
                Instantiate(Taronja, posicioX1Y2, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y3, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y4, Quaternion.identity);
                Instantiate(Melo, posicioX1Y5, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX1Y6, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y7, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y8, Quaternion.identity);
                Instantiate(Caixa, posicioX1Y9, Quaternion.identity);

                Instantiate(Fresa, posicioX2Y1, Quaternion.identity);
                Instantiate(BombollaBlava, posicioX2Y2, Quaternion.identity);
                Instantiate(Fresa, posicioX2Y3, Quaternion.identity);
                Instantiate(Tomaquet, posicioX2Y4, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y5, Quaternion.identity);
                Instantiate(BombollaBlava, posicioX2Y6, Quaternion.identity);
                Instantiate(Tomaquet, posicioX2Y7, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y8, Quaternion.identity);
                Instantiate(llimonaTancada, posicioX2Y9, Quaternion.identity);

                Instantiate(Melo, posicioX3Y1, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX3Y2, Quaternion.identity);
                Instantiate(Melo, posicioX3Y3, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y4, Quaternion.identity);
                Instantiate(Bomba, posicioX3Y5, Quaternion.identity);
                Instantiate(Llimona, posicioX3Y6, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y7, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX3Y8, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y9, Quaternion.identity);

                Instantiate(Taronja, posicioX4Y1, Quaternion.identity);
                Instantiate(Caixa, posicioX4Y2, Quaternion.identity);
                Instantiate(Melo, posicioX4Y3, Quaternion.identity);
                Instantiate(Melo, posicioX4Y4, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y5, Quaternion.identity);
                Instantiate(Tomaquet, posicioX4Y6, Quaternion.identity);
                Instantiate(Melo, posicioX4Y7, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX4Y8, Quaternion.identity);
                Instantiate(Llimona, posicioX4Y9, Quaternion.identity);

                Instantiate(llimonaTancada, posicioX5Y1, Quaternion.identity);
                Instantiate(Taronja, posicioX5Y2, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y3, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX5Y4, Quaternion.identity);
                Instantiate(Taronja, posicioX5Y5, Quaternion.identity);
                Instantiate(Fresa, posicioX5Y6, Quaternion.identity);
                Instantiate(Caixa, posicioX5Y7, Quaternion.identity);
                Instantiate(Melo, posicioX5Y8, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX5Y9, Quaternion.identity);

                break;



            case "Scene11":

                Instantiate(tomaquetTancat, posicioX1Y1, Quaternion.identity);
                Instantiate(Bomba, posicioX1Y2, Quaternion.identity);
                Instantiate(Melo, posicioX1Y3, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y4, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y5, Quaternion.identity);
                Instantiate(Taronja, posicioX1Y6, Quaternion.identity);
                Instantiate(Llimona, posicioX1Y7, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y8, Quaternion.identity);
                Instantiate(taronjaTancada, posicioX1Y9, Quaternion.identity);

                Instantiate(Caixa, posicioX2Y1, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX2Y2, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y3, Quaternion.identity);
                Instantiate(Melo, posicioX2Y4, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y5, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y6, Quaternion.identity);
                Instantiate(Melo, posicioX2Y7, Quaternion.identity);
                Instantiate(Tomaquet, posicioX2Y8, Quaternion.identity);
                Instantiate(taronjaTancada, posicioX2Y9, Quaternion.identity);

                Instantiate(taronjaTancada, posicioX3Y1, Quaternion.identity);
                Instantiate(Tomaquet, posicioX3Y2, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y3, Quaternion.identity);
                Instantiate(Bomba, posicioX3Y4, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y5, Quaternion.identity);
                Instantiate(Melo, posicioX3Y6, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y7, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX3Y8, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y9, Quaternion.identity);

                Instantiate(Melo, posicioX4Y1, Quaternion.identity);
                Instantiate(BombollaBlava, posicioX4Y2, Quaternion.identity);
                Instantiate(Tomaquet, posicioX4Y3, Quaternion.identity);
                Instantiate(Llimona, posicioX4Y4, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y5, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y6, Quaternion.identity);
                Instantiate(Llimona, posicioX4Y7, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y8, Quaternion.identity);
                Instantiate(taronjaTancada, posicioX4Y9, Quaternion.identity);

                Instantiate(Melo, posicioX5Y1, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX5Y2, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y3, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX5Y4, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX5Y5, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX5Y6, Quaternion.identity);
                Instantiate(Melo, posicioX5Y7, Quaternion.identity);
                Instantiate(BombollaBlava, posicioX5Y8, Quaternion.identity);
                Instantiate(taronjaTancada, posicioX5Y9, Quaternion.identity);

                break;


            case "Scene12":

                Instantiate(Fresa, posicioX1Y1, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y2, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y3, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y4, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y5, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y6, Quaternion.identity);
                Instantiate(Melo, posicioX1Y7, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y8, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y9, Quaternion.identity);

                Instantiate(Taronja, posicioX2Y1, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y2, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y3, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y4, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y5, Quaternion.identity);
                Instantiate(Fresa, posicioX2Y6, Quaternion.identity);
                Instantiate(Fresa, posicioX2Y7, Quaternion.identity);
                Instantiate(Fresa, posicioX2Y8, Quaternion.identity);
                Instantiate(Melo, posicioX2Y9, Quaternion.identity);

                Instantiate(Fresa, posicioX3Y1, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y2, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y3, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y4, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y5, Quaternion.identity);
                Instantiate(Llimona, posicioX3Y6, Quaternion.identity);
                Instantiate(Llimona, posicioX3Y7, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y8, Quaternion.identity);
                Instantiate(Llimona, posicioX3Y9, Quaternion.identity);

                Instantiate(Melo, posicioX4Y1, Quaternion.identity);
                Instantiate(Llimona, posicioX4Y2, Quaternion.identity);
                Instantiate(Melo, posicioX4Y3, Quaternion.identity);
                Instantiate(Llimona, posicioX4Y4, Quaternion.identity);
                Instantiate(Melo, posicioX4Y5, Quaternion.identity);
                Instantiate(Llimona, posicioX4Y6, Quaternion.identity);
                Instantiate(Llimona, posicioX4Y7, Quaternion.identity);
                Instantiate(Melo, posicioX4Y8, Quaternion.identity);
                Instantiate(Melo, posicioX4Y9, Quaternion.identity);

                Instantiate(Llimona, posicioX5Y1, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y2, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y3, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y4, Quaternion.identity);
                Instantiate(Fresa, posicioX5Y5, Quaternion.identity);
                Instantiate(Fresa, posicioX5Y6, Quaternion.identity);
                Instantiate(Taronja, posicioX5Y7, Quaternion.identity);
                Instantiate(Fresa, posicioX5Y8, Quaternion.identity);
                Instantiate(Taronja, posicioX5Y9, Quaternion.identity);

                break;


            case "Scene13":

                Instantiate(Fresa, posicioX1Y1, Quaternion.identity);
                Instantiate(Llimona, posicioX1Y2, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y3, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX1Y4, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX1Y5, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y6, Quaternion.identity);
                Instantiate(Caixa, posicioX1Y7, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX1Y8, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y9, Quaternion.identity);

                Instantiate(Fresa, posicioX2Y1, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y2, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y3, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX2Y4, Quaternion.identity);
                Instantiate(Tomaquet, posicioX2Y5, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX2Y6, Quaternion.identity);
                Instantiate(Melo, posicioX2Y7, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y8, Quaternion.identity);
                Instantiate(Cireres, posicioX2Y9, Quaternion.identity);

                Instantiate(Taronja, posicioX3Y1, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y2, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX3Y3, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y4, Quaternion.identity);
                Instantiate(BombollaBlava, posicioX3Y5, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y6, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX3Y7, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y8, Quaternion.identity);
                Instantiate(Melo, posicioX3Y9, Quaternion.identity);

                Instantiate(Fresa, posicioX4Y1, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX4Y2, Quaternion.identity);
                Instantiate(Melo, posicioX4Y3, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y4, Quaternion.identity);
                Instantiate(Llimona, posicioX4Y5, Quaternion.identity);
                Instantiate(Tomaquet, posicioX4Y6, Quaternion.identity);
                Instantiate(Caixa, posicioX4Y7, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX4Y8, Quaternion.identity);
                Instantiate(Bomba, posicioX4Y9, Quaternion.identity);

                Instantiate(EstrellaBlava, posicioX5Y1, Quaternion.identity);
                Instantiate(Melo, posicioX5Y2, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y3, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y4, Quaternion.identity);
                Instantiate(Melo, posicioX5Y5, Quaternion.identity);
                Instantiate(Melo, posicioX5Y6, Quaternion.identity);
                Instantiate(Taronja, posicioX5Y7, Quaternion.identity);
                Instantiate(Taronja, posicioX5Y8, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX5Y9, Quaternion.identity);

                break;


            case "Scene14":

                Instantiate(Caixa, posicioX1Y1, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y2, Quaternion.identity);
                Instantiate(Taronja, posicioX1Y3, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y4, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y5, Quaternion.identity);
                Instantiate(Taronja, posicioX1Y6, Quaternion.identity);
                Instantiate(BombollaBlava, posicioX1Y7, Quaternion.identity);
                Instantiate(Taronja, posicioX1Y8, Quaternion.identity);
                Instantiate(Caixa, posicioX1Y9, Quaternion.identity);

                Instantiate(tomaquetTancat, posicioX2Y1, Quaternion.identity);
                Instantiate(Caixa, posicioX2Y2, Quaternion.identity);
                Instantiate(BombollaBlava, posicioX2Y3, Quaternion.identity);
                Instantiate(Melo, posicioX2Y4, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y5, Quaternion.identity);
                Instantiate(Fresa, posicioX2Y6, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y7, Quaternion.identity);
                Instantiate(Caixa, posicioX2Y8, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX2Y9, Quaternion.identity);

                Instantiate(tomaquetTancat, posicioX3Y1, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX3Y2, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y3, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y4, Quaternion.identity);
                Instantiate(Bomba, posicioX3Y5, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y6, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y7, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX3Y8, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX3Y9, Quaternion.identity);

                Instantiate(tomaquetTancat, posicioX4Y1, Quaternion.identity);
                Instantiate(Caixa, posicioX4Y2, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y3, Quaternion.identity);
                Instantiate(Melo, posicioX4Y4, Quaternion.identity);
                Instantiate(Melo, posicioX4Y5, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y6, Quaternion.identity);
                Instantiate(Tomaquet, posicioX4Y7, Quaternion.identity);
                Instantiate(Caixa, posicioX4Y8, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX4Y9, Quaternion.identity);

                Instantiate(Caixa, posicioX5Y1, Quaternion.identity);
                Instantiate(Cireres, posicioX5Y2, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y3, Quaternion.identity);
                Instantiate(Melo, posicioX5Y4, Quaternion.identity);
                Instantiate(Fresa, posicioX5Y5, Quaternion.identity);
                Instantiate(Taronja, posicioX5Y6, Quaternion.identity);
                Instantiate(Melo, posicioX5Y7, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX5Y8, Quaternion.identity);
                Instantiate(Caixa, posicioX5Y9, Quaternion.identity);

                break;



            case "Scene15":

                Instantiate(Taronja, posicioX1Y1, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX1Y2, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX1Y3, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y4, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y5, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y6, Quaternion.identity);
                Instantiate(Tomaquet, posicioX1Y7, Quaternion.identity);
                Instantiate(Fresa, posicioX1Y8, Quaternion.identity);
                Instantiate(Bomba, posicioX1Y9, Quaternion.identity);

                Instantiate(Tomaquet, posicioX2Y1, Quaternion.identity);
                Instantiate(Taronja, posicioX2Y2, Quaternion.identity);
                Instantiate(Tomaquet, posicioX2Y3, Quaternion.identity);
                Instantiate(Tomaquet, posicioX2Y4, Quaternion.identity);
                Instantiate(Llimona, posicioX2Y5, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX2Y6, Quaternion.identity);
                Instantiate(meloTancat, posicioX2Y7, Quaternion.identity);
                Instantiate(Fresa, posicioX2Y8, Quaternion.identity);
                Instantiate(Melo, posicioX2Y9, Quaternion.identity);

                Instantiate(Taronja, posicioX3Y1, Quaternion.identity);
                Instantiate(meloTancat, posicioX3Y2, Quaternion.identity);
                Instantiate(Llimona, posicioX3Y3, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y4, Quaternion.identity);
                Instantiate(Fresa, posicioX3Y5, Quaternion.identity);
                Instantiate(Llimona, posicioX3Y6, Quaternion.identity);
                Instantiate(Melo, posicioX3Y7, Quaternion.identity);
                Instantiate(Taronja, posicioX3Y8, Quaternion.identity);
                Instantiate(Caixa, posicioX3Y9, Quaternion.identity);

                Instantiate(Tomaquet, posicioX4Y1, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y2, Quaternion.identity);
                Instantiate(BombollaBlava, posicioX4Y3, Quaternion.identity);
                Instantiate(Taronja, posicioX4Y4, Quaternion.identity);
                Instantiate(meloTancat, posicioX4Y5, Quaternion.identity);
                Instantiate(Taronja, posicioX4Y6, Quaternion.identity);
                Instantiate(Fresa, posicioX4Y7, Quaternion.identity);
                Instantiate(EstrellaBlava, posicioX4Y8, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX4Y9, Quaternion.identity);

                Instantiate(Llimona, posicioX5Y1, Quaternion.identity);
                Instantiate(Llimona, posicioX5Y2, Quaternion.identity);
                Instantiate(Fresa, posicioX5Y3, Quaternion.identity);
                Instantiate(Bomba, posicioX5Y4, Quaternion.identity);
                Instantiate(Fresa, posicioX5Y5, Quaternion.identity);
                Instantiate(BombollaBlava, posicioX5Y6, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX5Y7, Quaternion.identity);
                Instantiate(tomaquetTancat, posicioX5Y8, Quaternion.identity);
                Instantiate(Caixa, posicioX5Y9, Quaternion.identity);

                break;



            

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
