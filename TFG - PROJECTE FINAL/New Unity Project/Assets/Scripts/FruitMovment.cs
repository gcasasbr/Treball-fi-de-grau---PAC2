

using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class FruitMovment : MonoBehaviour
{
    // -Start is called before the first frame update

    public bool iniciar;
    public GameObject chest;
    public GameObject GameController;
    public int prova;
    public GameObject grid;
    
    public bool intercanviar;
    public GameObject objecte1;
    public GameObject objecte2;
    public string tipus_fruita1;
    public string tipus_fruita2; 
    public Vector3 posicio1;
    public Vector3 posicio2;

    public GameObject splater_green;

    public bool disparador;
    public bool estrellaTocada;

    public bool desplasar;

    public Vector3 posicio;

    public int n;

    public bool prova2;
    public string objecteProva;
    public float numero;

    public RaycastHit2D hit3;
    public RaycastHit2D hit4;


    public bool prova54;

    public string impacteProva;

    public float impacteY;


    
    public bool ajustar;
    public Vector3 posicioNova;

    public bool desplasar2;
    public bool fila7;
    public bool fila6;
    public bool fila5;
    public bool fila4;
    public bool fila3;
    public bool fila2;
    public bool fila1;
    public bool fila0;


    public void Parar2()
    {
        desplasar = false;
        
        Transform[] allChildren = GetComponentsInChildren<Transform>();

        foreach (Transform child in allChildren)
        {
            child.gameObject.SetActive(false);
        }

        
    }


    public void parar()
    {
        Invoke("Parar2", 0.8f);
        
    }


    public void destruir5()
    {
        Transform[] allChildren = GetComponentsInChildren<Transform>();

        foreach (Transform child in allChildren)
        {
            child.gameObject.SetActive(false);
        }
    }

    public void destruir4()
    {
        if (this.gameObject.tag == "Tancat")
        {
            GameController.GetComponent<GameController>().punts = GameController.GetComponent<GameController>().punts + 10;

            if (this.gameObject.name.Contains("Tomaquet")) GameController.GetComponent<GameController>().contadorTomaquets = GameController.GetComponent<GameController>().contadorTomaquets + 1;
            if (this.gameObject.name.Contains("Melo")) GameController.GetComponent<GameController>().contadorMelo = GameController.GetComponent<GameController>().contadorMelo + 1;
            if (this.gameObject.name.Contains("Llimona")) GameController.GetComponent<GameController>().contadorLlimona = GameController.GetComponent<GameController>().contadorLlimona + 1;
            if (this.gameObject.name.Contains("Fresa")) GameController.GetComponent<GameController>().contadorFresa = GameController.GetComponent<GameController>().contadorFresa + 1;
            if (this.gameObject.name.Contains("Taronja")) GameController.GetComponent<GameController>().contadorTaronja = GameController.GetComponent<GameController>().contadorTaronja + 1;
        }

        Transform[] allChildren = GetComponentsInChildren<Transform>();

        foreach (Transform child in allChildren)
        {
            child.gameObject.SetActive(false);
        }

    }


    public void destruir3()
    {

        if (disparador)
        {
            disparador = false;
            Invoke("destruir4", 0.7f);
                       
        }

    }

       
    
    public void Contar()
    {
       
        GameController.GetComponent<GameController>().punts = GameController.GetComponent<GameController>().punts * 2;
                       

    }

    public void destruir2()
    {

        if (disparador)
        {
            disparador = false;

            Invoke("Contar", 0.5f);
            
            Transform[] allChildren = GetComponentsInChildren<Transform>();

            foreach (Transform child in allChildren)
            {
                child.gameObject.SetActive(false);
            }

            if(this.gameObject.tag == "Bomba"){

                this.gameObject.transform.GetChild(2).gameObject.SetActive(false);

            }


            chest.transform.GetChild(1).gameObject.SetActive(false);
            chest.transform.GetChild(1).gameObject.transform.position = posicio;

            desplasar = false;
        }
    }


    public void destruir()
    {

        
        if (disparador)
        {
            
            disparador = false;

            if (this.gameObject.tag == "Bombolla")
            {
                desplasar = true;
                Invoke("Contar2", 0.7f);
                Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                //this.transform.GetChild(7).gameObject.SetActive(true);
                prova = 54;


            }
            else
            {

                this.transform.Find("body").gameObject.SetActive(false);
                Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                Destroy(this.gameObject.GetComponentInChildren<SpriteRenderer>());
                Destroy(this.gameObject.GetComponent<Rigidbody2D>());

                if (!this.gameObject.tag.Equals("Bombolla") || !this.gameObject.tag.Equals("EstrellaDaurada") || !this.gameObject.tag.Equals("Tancat") || !this.gameObject.tag.Equals("Bomba"))
                {

                    GameController.GetComponent<GameController>().punts = GameController.GetComponent<GameController>().punts + 10;
                    
                    if(this.gameObject.tag=="Tomaquet") GameController.GetComponent<GameController>().contadorTomaquets = GameController.GetComponent<GameController>().contadorTomaquets + 1;
                    if (this.gameObject.tag == "Melo") GameController.GetComponent<GameController>().contadorMelo = GameController.GetComponent<GameController>().contadorMelo + 1;
                    if (this.gameObject.tag == "Llimona") GameController.GetComponent<GameController>().contadorLlimona = GameController.GetComponent<GameController>().contadorLlimona + 1;
                    if (this.gameObject.tag == "Fresa") GameController.GetComponent<GameController>().contadorFresa = GameController.GetComponent<GameController>().contadorFresa + 1;
                    if (this.gameObject.tag == "Taronja") GameController.GetComponent<GameController>().contadorTaronja = GameController.GetComponent<GameController>().contadorTaronja + 1;

                }

                else
                {
                    if (this.gameObject.tag.Equals("Bombolla")) GameController.GetComponent<GameController>().punts = GameController.GetComponent<GameController>().punts - 50;
                    if (this.gameObject.tag.Equals("Tancat"))
                    {
                        GameController.GetComponent<GameController>().punts = GameController.GetComponent<GameController>().punts + 10;

                        if (this.gameObject.name.Contains("Tomaquet")) GameController.GetComponent<GameController>().contadorTomaquets = GameController.GetComponent<GameController>().contadorTomaquets + 1;
                        if (this.gameObject.name.Contains("Melo")) GameController.GetComponent<GameController>().contadorMelo = GameController.GetComponent<GameController>().contadorMelo + 1;
                        if (this.gameObject.name.Contains("Llimona")) GameController.GetComponent<GameController>().contadorLlimona = GameController.GetComponent<GameController>().contadorLlimona + 1;
                        if (this.gameObject.name.Contains("Fresa")) GameController.GetComponent<GameController>().contadorFresa = GameController.GetComponent<GameController>().contadorFresa + 1;
                        if (this.gameObject.name.Contains("Taronja")) GameController.GetComponent<GameController>().contadorTaronja = GameController.GetComponent<GameController>().contadorTaronja + 1;


                    }
                }


                if (this.gameObject.tag == "Estrella")
                {
                    GameController.GetComponent<GameController>().estrellaTocada = true;
                    GameController.GetComponent<GameController>().posicioYestrella = this.gameObject.transform.position.y;
                }


                //Desactivem fill amb nom PuntsFruita      
                Transform[] allChildren = GetComponentsInChildren<Transform>();

                foreach (Transform child in allChildren)
                {
                    if (child.gameObject.name == "PuntsFruita")
                    {
                        child.gameObject.SetActive(false);
                    }

                    if (this.gameObject.tag == "Estrella")
                    {
                        child.gameObject.SetActive(false);
                    }
                }



                if (this.gameObject.tag.Equals("Bombolla"))
                {
                    chest.transform.GetChild(1).gameObject.SetActive(false);
                    chest.transform.GetChild(1).gameObject.transform.position = posicio;

                }

            }   
           
            desplasar = false;
                        
        }


    }
        
       
    void Start()
    {
        iniciar = false;
        chest = GameObject.Find("Chest");
        GameController = GameObject.Find("GameController");
        GameController.GetComponent<GameController>().ObjectesEnPantalla.Add(this.gameObject);

        prova = 0;
        intercanviar = false;

        objecte1 = null;
        objecte2 = null;
        disparador = true;

        estrellaTocada = false;

        desplasar = false;
        desplasar2 = false;

        posicio = chest.transform.GetChild(1).gameObject.transform.position;

        prova54 = false;

        fila7 = false;
        fila6 = false;
        fila5 = false;
        fila4 = false;
        fila3 = false;
        fila2 = false;
        fila1 = false;
    }

    
    public void finalitzar_intercanvi()
    {

        objecte1 = null;
        objecte2 = null;
        intercanviar = false;

        GameController.GetComponent<GameController>().intercanvienProces = false;
    }
    
    
    public void Contar2()
    {
        GameController.GetComponent<GameController>().punts = GameController.GetComponent<GameController>().punts - 50;
        desplasar = false;
        chest.transform.GetChild(1).gameObject.SetActive(false);
        chest.transform.GetChild(1).gameObject.transform.position = posicio;
    }

    
    // Update is called once per frame
    void Update()
    {

               


        if (!GameController.GetComponent<GameController>().intercanvienProces)
        {
            hit3 = Physics2D.Raycast(new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z), -Vector2.up);

            if (this.gameObject.tag != "Bomba" && this.gameObject.tag != "Caixa" && this.gameObject.tag != "Tancat" && this.gameObject.tag != "Bombolla" && this.gameObject.tag != "EstrellaDaurada")
            {

                if (hit3 != null && Vector3.Distance(hit3.collider.gameObject.transform.position, this.transform.position) > 0.7f)

                {
                    if (!intercanviar)
                    {
                                                   
                            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.05f, this.transform.position.z);
                            objecteProva = hit3.collider.gameObject.tag;
                            numero = hit3.distance;
                                                   
                    }
                }

                else
                {
                    //Fem que totes les fruites de la mateixa linia estiguin en la mateixa posicio y, sino les linies queden amb alts i baixos i queda lleig

                    if (!intercanviar)
                    {
                        if (Mathf.Abs(this.gameObject.transform.position.y - 3.63f) < 0.2f)
                        {
                            this.transform.position = Vector3.Lerp(this.gameObject.transform.position, new Vector3(this.gameObject.transform.position.x, 3.63f, this.gameObject.transform.position.z), 0.01f);
                        }
                        else
                        {
                            if (Mathf.Abs(this.gameObject.transform.position.y - 3.63f) < 0.05f)
                            {
                                this.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
                            }
                        }


                        if (Mathf.Abs(this.gameObject.transform.position.y - 2.93f) < 0.2f)
                        {
                            this.transform.position = Vector3.Lerp(this.gameObject.transform.position, new Vector3(this.gameObject.transform.position.x, 2.93f, this.gameObject.transform.position.z), 0.01f);
                        }
                        else
                        {
                            if (Mathf.Abs(this.gameObject.transform.position.y - 2.93f) < 0.05f)
                            {
                                this.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
                            }
                        }


                        if (Mathf.Abs(this.gameObject.transform.position.y - 2.28f) < 0.2f)
                        {
                            this.transform.position = Vector3.Lerp(this.gameObject.transform.position, new Vector3(this.gameObject.transform.position.x, 2.28f, this.gameObject.transform.position.z), 0.01f);
                        }
                        else
                        {
                            if (Mathf.Abs(this.gameObject.transform.position.y - 2.28f) < 0.05f)
                            {
                                this.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
                            }
                        }


                        if (Mathf.Abs(this.gameObject.transform.position.y - 1.6f) < 0.2f)
                        {
                            this.transform.position = Vector3.Lerp(this.gameObject.transform.position, new Vector3(this.gameObject.transform.position.x, 1.6f, this.gameObject.transform.position.z), 0.01f);
                        }
                        else
                        {
                            if (Mathf.Abs(this.gameObject.transform.position.y - 1.6f) < 0.05f)
                            {
                                this.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
                            }
                        }

                        if (Mathf.Abs(this.gameObject.transform.position.y - 0.92f) < 0.2f)
                        {
                            this.transform.position = Vector3.Lerp(this.gameObject.transform.position, new Vector3(this.gameObject.transform.position.x, 0.92f, this.gameObject.transform.position.z), 0.01f);
                        }
                        else
                        {
                            if (Mathf.Abs(this.gameObject.transform.position.y - 0.92f) < 0.05f)
                            {
                                this.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
                            }
                        }

                        if (Mathf.Abs(this.gameObject.transform.position.y - 0.22f) < 0.2f)
                        {
                            this.transform.position = Vector3.Lerp(this.gameObject.transform.position, new Vector3(this.gameObject.transform.position.x, 0.22f, this.gameObject.transform.position.z), 0.01f);
                        }
                        else
                        {
                            if (Mathf.Abs(this.gameObject.transform.position.y - 0.22f) < 0.05f)
                            {
                                this.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
                            }
                        }

                        if (Mathf.Abs(this.gameObject.transform.position.y - (-0.14f)) < 0.2f)
                        {
                            this.transform.position = Vector3.Lerp(this.gameObject.transform.position, new Vector3(this.gameObject.transform.position.x, -0.14f, this.gameObject.transform.position.z), 0.01f);
                        }
                        else
                        {
                            if (Mathf.Abs(this.gameObject.transform.position.y - (-0.14f)) < 0.05f)
                            {
                                this.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
                            }
                        }

                        if (Mathf.Abs(this.gameObject.transform.position.y - (-1.13f)) < 0.2f)
                        {
                            this.transform.position = Vector3.Lerp(this.gameObject.transform.position, new Vector3(this.gameObject.transform.position.x, -1.13f, this.gameObject.transform.position.z), 0.01f);
                        }
                        else
                        {
                            if (Mathf.Abs(this.gameObject.transform.position.y - (-1.13f)) < 0.05f)
                            {
                                this.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
                            }
                        }

                        if (Mathf.Abs(this.gameObject.transform.position.y - (-1.8f)) < 0.2f)
                        {
                            this.transform.position = Vector3.Lerp(this.gameObject.transform.position, new Vector3(this.gameObject.transform.position.x, -1.8f, this.gameObject.transform.position.z), 0.01f);
                        }
                        else
                        {
                            if (Mathf.Abs(this.gameObject.transform.position.y - (-1.8f)) < 0.05f)
                            {
                                this.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
                            }
                        }


                    }

                }

            }
           
        }




        
        if (desplasar)
        {

            
            if (this.gameObject.tag == "Bombolla" || this.gameObject.tag == "EstrellaDaurada")
            {
                chest.transform.GetChild(1).gameObject.transform.position = new Vector3(chest.transform.GetChild(1).gameObject.transform.position.x, chest.transform.GetChild(1).gameObject.transform.position.y + 0.0005f, chest.transform.GetChild(1).gameObject.transform.position.z);
                
            }
            else
            {
                this.transform.GetChild(7).gameObject.transform.position = new Vector3(this.transform.GetChild(7).gameObject.transform.position.x, this.transform.GetChild(7).gameObject.transform.position.y + 0.0005f, this.transform.GetChild(7).gameObject.transform.position.z);
                
            }
        }
        

        if (intercanviar)
        {

            if (objecte1 != null)
            {
                objecte1.GetComponent<Transform>().position = Vector3.Lerp(objecte1.transform.position, posicio2, Time.deltaTime * 5f);
                objecte2.GetComponent<Transform>().position = Vector3.Lerp(objecte2.transform.position, posicio1, Time.deltaTime * 5f);

                if (Vector3.Distance(objecte1.transform.position, posicio2) < 0.01f && Vector3.Distance(objecte2.transform.position, posicio1) < 0.001f)
                {
                    finalitzar_intercanvi();
                }

            }

        }


        if (iniciar) 
        {

            if (this.gameObject.tag == "EstrellaDaurada")
            {

                this.transform.GetChild(3).gameObject.SetActive(false);
                this.transform.GetChild(1).gameObject.SetActive(true);

                chest.transform.GetChild(1).gameObject.SetActive(true);
                desplasar = true;

                Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                Destroy(this.gameObject.GetComponentInChildren<SpriteRenderer>());

                Invoke("destruir2", 0.8f);
                this.GetComponent<AudioSource>().Play(0);
                iniciar = false;
                                
            }
            else
            {

                if (this.gameObject.tag == "Bombolla")
                {
                    this.GetComponent<AudioSource>().Play(0);
                }
                else
                {
                    chest.transform.GetChild(1).gameObject.GetComponent<Text>().text = "";
                }


                    if (this.gameObject.tag == "Bomba")
                {
                    
                    for (n = 0; n < GameController.GetComponent<GameController>().ObjectesEnPantalla.Count; n++)
                    {
                        if (GameController.GetComponent<GameController>().ObjectesEnPantalla[n].tag == "Tancat")
                        {
                           

                            if (GameController.GetComponent<GameController>().tipus_fruita2 != null)
                            {
                                

                                if (GameController.GetComponent<GameController>().ObjectesEnPantalla[n].name.Contains(GameController.GetComponent<GameController>().tipus_fruita2))
                                {
                                   

                                    GameController.GetComponent<GameController>().ObjectesEnPantalla[n].transform.GetChild(9).gameObject.SetActive(true);
                                    GameController.GetComponent<GameController>().ObjectesEnPantalla[n].transform.GetChild(7).gameObject.SetActive(true);
                                    GameController.GetComponent<GameController>().ObjectesEnPantalla[n].transform.GetChild(8).gameObject.SetActive(false);
                                    GameController.GetComponent<GameController>().ObjectesEnPantalla[n].GetComponent<FruitMovment>().desplasar = true;
                                    GameController.GetComponent<GameController>().ObjectesEnPantalla[n].GetComponent<FruitMovment>().parar();
                                    GameController.GetComponent<GameController>().ObjectesEnPantalla[n].GetComponent<FruitMovment>().destruir3();
                                    Invoke("destruir5", 0.5f);                                   
                                    Destroy(GameController.GetComponent<GameController>().ObjectesEnPantalla[n].GetComponent<BoxCollider2D>());
                                    Destroy(GameController.GetComponent<GameController>().ObjectesEnPantalla[n].GetComponentInChildren<SpriteRenderer>());
                                }
                                
                            }
                        }
                    }

                    this.GetComponent<SpriteRenderer>().enabled = false;
                    this.GetComponent<BoxCollider2D>().enabled = false;
                    this.transform.GetChild(2).gameObject.SetActive(false);
                    if(this.gameObject.transform.GetChild(1).name!="wood_02") this.transform.GetChild(1).gameObject.SetActive(true);
                    this.GetComponent<AudioSource>().Play(0);

                }
                else
                {

                    if (this.gameObject.tag != "Caixa")
                    {
                        this.transform.Find("body").gameObject.SetActive(false);

                        
                        if (!estrellaTocada)
                        {
                            if (this.gameObject.tag == "Melo") this.transform.GetChild(2).gameObject.SetActive(true);
                            if (this.gameObject.tag == "Tomaquet") this.transform.GetChild(3).gameObject.SetActive(true);
                            if (this.gameObject.tag == "Fresa") this.transform.GetChild(3).gameObject.SetActive(true);
                            if (this.gameObject.tag == "Taronja") this.transform.GetChild(4).gameObject.SetActive(true);
                            if (this.gameObject.tag == "Llimona") this.transform.GetChild(2).gameObject.SetActive(true);
                            if (this.gameObject.tag == "Llimona2") this.transform.GetChild(5).gameObject.SetActive(true);
                            if (this.gameObject.tag == "Bombolla")
                            {

                                this.transform.GetChild(7).gameObject.SetActive(true);
                                this.transform.GetChild(9).gameObject.SetActive(false);
                            }


                            this.GetComponent<AudioSource>().Play(0);

                            if (this.gameObject.tag == "Estrella") this.transform.GetChild(6).gameObject.SetActive(true);



                            if (!this.gameObject.tag.Equals("Bombolla"))
                            {
                                this.transform.GetChild(7).gameObject.SetActive(true);
                                desplasar = true;
                            }
                            else
                            {
                                chest.transform.GetChild(1).gameObject.SetActive(true);
                                desplasar = true;
                            }
                        }
                        else
                        {
                            if (this.gameObject.tag == "Bombolla")
                            {
                                this.transform.GetChild(7).gameObject.SetActive(true);
                                //Invoke("Contar2", 0.9f);
                                disparador = true;
                                chest.transform.GetChild(1).gameObject.SetActive(true);
                                this.transform.GetChild(9).gameObject.SetActive(false);
                                desplasar = true;
                                this.GetComponent<AudioSource>().Play(0);
                            }

                            else
                            {
                                if (this.gameObject.tag == "Estrella")
                                {
                                    this.transform.GetChild(6).gameObject.SetActive(true);
                                    this.transform.GetChild(7).gameObject.SetActive(true);
                                    desplasar = true;
                                }
                                else
                                {
                                    if (this.gameObject.tag == "Melo") this.transform.GetChild(2).gameObject.SetActive(true);
                                    if (this.gameObject.tag == "Tomaquet") this.transform.GetChild(3).gameObject.SetActive(true);
                                    if (this.gameObject.tag == "Fresa") this.transform.GetChild(3).gameObject.SetActive(true);
                                    if (this.gameObject.tag == "Taronja") this.transform.GetChild(4).gameObject.SetActive(true);
                                    if (this.gameObject.tag == "Llimona") this.transform.GetChild(2).gameObject.SetActive(true);
                                    if (this.gameObject.tag == "Llimona2") this.transform.GetChild(5).gameObject.SetActive(true);
                                    if (this.gameObject.tag == "Bombolla")
                                    {
                                        this.transform.GetChild(7).gameObject.SetActive(true);
                                        this.transform.GetChild(9).gameObject.SetActive(false);
                                    }
                                    this.transform.GetChild(7).gameObject.SetActive(true);
                                    desplasar = true;
                                    this.GetComponent<AudioSource>().Play(0);

                                }

                            }

                        }

                        iniciar = false;

                        Invoke("destruir", 0.883f);
                        



                    }
                }

                
            }
            
        }

    }

    public void intercanvi(GameObject objecte1, GameObject objecte2)
    {
        this.objecte1 = objecte1;
        this.objecte2 = objecte2;
        tipus_fruita1 = objecte1.gameObject.tag;
        tipus_fruita2 = objecte2.gameObject.tag;

        posicio1 = objecte1.transform.position;
        posicio2 = objecte2.transform.position;
             
        intercanviar = true;
       
        
    }
    
}
