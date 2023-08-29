using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoBool : MonoBehaviour
{
    public GameObject fuego1;
    public GameObject fuego2;
    public GameObject fuego3;
    public GameObject coll1;    
    public GameObject coll2;
    public GameObject coll3;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(fuego1.activeSelf){
            coll1.SetActive(true);
        }
        else{
            coll1.SetActive(false);
        }
        if(fuego2.activeSelf){
            coll2.SetActive(true);
        }
        else{
            coll2.SetActive(false);
        }
        if(fuego3.activeSelf){
            coll3.SetActive(true);
        }
        else{
            coll3.SetActive(false);
        }
    }
}
