using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idioma : MonoBehaviour
{

    public int IdiomaSeleccionat;
    public int pantallaSeleccionada;
    public int pantallesPassades;
    public int pantallesPassadesMon2;
    public int pantallesPassadesMon3;
    public int mon;

    static Idioma instance;

    
    void Start()
    {
        pantallesPassades = 1;
        pantallesPassadesMon2 = 1;
        pantallesPassadesMon3 = 1;
        mon = 0;
        DontDestroyOnLoad(this.gameObject);
    }

    void Awake()
    {

        if (instance != null)
        {
            Destroy(gameObject);
        }

        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
