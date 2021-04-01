using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Nuvol : MonoBehaviour
{

    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.right * Time.deltaTime, Space.World);

        if (transform.position.x < -8)
        {
           Instantiate(this.gameObject, new Vector3(8f,transform.position.y, transform.position.z), Quaternion.identity);
            //nuvol.GetComponent<Transform>().SetParent(canvaspantalla);
            Destroy(this.gameObject);
        }

    }
}
