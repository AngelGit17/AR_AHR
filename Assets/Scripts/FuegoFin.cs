using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoFin : MonoBehaviour
{
    public GameObject fuego1;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "humo"){
            print("hi");
            fuego1.SetActive(false);
        }
    }
}
