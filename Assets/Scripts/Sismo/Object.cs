using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public GameObject text;
    public GameObject Boton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "reticula"){
            text.SetActive(true);
            Boton.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "reticula"){
            Boton.SetActive(false);
            text.SetActive(false);
        }
    }
        
}
