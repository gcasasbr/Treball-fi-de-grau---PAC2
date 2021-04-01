using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class So : MonoBehaviour
{

    public GameObject go;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    
    
    void Start()
    {
        go = GameObject.Find("So");
    }

    // Update is called once per frame
    void Update()
    {
        if (go != null && go != this.gameObject)
        {
            Destroy(this.gameObject);
        }
    }
}
