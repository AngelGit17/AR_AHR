using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoFin : MonoBehaviour
{
    public GameObject fuego1;
    public GameObject CanvaUp;
    public GameObject PuertaCol;
    public GameObject alarm;
    

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "humo"){
            fuego1.SetActive(false);
            CanvaUp.SetActive(true);
            PuertaCol.SetActive(true);
            alarm.SetActive(false);
        }
    }
}
