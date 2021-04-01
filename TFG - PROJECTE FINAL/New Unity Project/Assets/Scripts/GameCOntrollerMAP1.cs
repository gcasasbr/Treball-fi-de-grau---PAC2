using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Configuration;

public class GameCOntrollerMAP1 : MonoBehaviour
{

    public int pantalla;
    public int j,i;
    public List<GameObject> pantalles = new List<GameObject>();  //Declarem la llista de GameObjects
    public List<GameObject> locks = new List<GameObject>();  //DEclarem la llista de GameObjects
    public GameObject objecteNodestruible;

    public GameObject objecte1;
    public GameObject objecte2;
    public GameObject objecte3;
    public GameObject objecte4;
    public GameObject objecte5;
    public GameObject objecte6;
    public GameObject objecte7;
    public GameObject objecte8;
    public GameObject objecte18;

    public GameObject objecte9;
    public GameObject objecte10;
    public GameObject objecte11;
    public GameObject objecte12;
    public GameObject objecte13;
    public GameObject objecte14;
    public GameObject objecte15;
    public GameObject objecte16;
    public GameObject objecte17;

    public int pantallesPassades;



    // Start is called before the first frame update
    
    void Start() 
    { 
       
              
        if (objecte1 != null)
        {
            pantalles.Add(objecte1);
            pantalles.Add(objecte2);
            pantalles.Add(objecte3);
            pantalles.Add(objecte4);
            pantalles.Add(objecte5);
            pantalles.Add(objecte6);
            pantalles.Add(objecte7);
            pantalles.Add(objecte8);
            pantalles.Add(objecte17);


            locks.Add(objecte9);
            locks.Add(objecte10);
            locks.Add(objecte11);
            locks.Add(objecte12);
            locks.Add(objecte13);
            locks.Add(objecte14);
            locks.Add(objecte15);
            locks.Add(objecte16);
            locks.Add(objecte18);

        }

        pantalla = 0;
        
        j = PlayerPrefs.GetInt("pantallesPassades");

        pantallesPassades = PlayerPrefs.GetInt("pantallesPassades");
        

        if (objecte1 != null)
        {
            pantalles[0].SetActive(true);
            locks[0].SetActive(false);

            
            for (i = 1; i < j; i++)
            {
                pantalles[i].SetActive(true);
                locks[i].SetActive(false);
                              
            }

            if (pantallesPassades == 9)
            {
                objecte17.SetActive(true);
                objecte18.SetActive(false);

            }
        }




    }

    // Update is called once per frame
    void Update()
    {

            
        
        
    }

    public void pantalla1()
    {
       
        PlayerPrefs.SetInt("pantallaSeleccionada", 1);
                      
        SceneManager.LoadScene(4);
    }


    public void pantalla2()
    {

        PlayerPrefs.SetInt("pantallaSeleccionada", 2);
       

        SceneManager.LoadScene(4);
    }


    public void pantalla3()
    {

        PlayerPrefs.SetInt("pantallaSeleccionada", 3);
        


        SceneManager.LoadScene(4);
    }


    public void pantalla4()
    {

        PlayerPrefs.SetInt("pantallaSeleccionada", 4);
       
        SceneManager.LoadScene(4);
    }

    public void pantalla5()
    {

        PlayerPrefs.SetInt("pantallaSeleccionada", 5);
       

        SceneManager.LoadScene(4);
    }


    public void pantalla6()
    {

        PlayerPrefs.SetInt("pantallaSeleccionada", 6);
      

        SceneManager.LoadScene(4);
    }


    public void pantalla7()
    {

        PlayerPrefs.SetInt("pantallaSeleccionada", 7);
       

        SceneManager.LoadScene(4);
    }


    public void pantalla8()
    {

        PlayerPrefs.SetInt("pantallaSeleccionada", 8);
      

        SceneManager.LoadScene(4);
    }


    public void pantalla9()
    {

        PlayerPrefs.SetInt("pantallaSeleccionada", 9);
     
        SceneManager.LoadScene(4);
    }


    public void tornar()
    {
        SceneManager.LoadScene(7);
    }

}
