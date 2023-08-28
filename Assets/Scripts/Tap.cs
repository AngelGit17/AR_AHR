using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour
{
    public GameObject extintor;
    public GameObject extinv;
    public GameObject extintoranim;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ButtonExt(){
        extintor.SetActive(false);
        extinv.SetActive(true);
    }
    public void ButtonExtOn(){
        extintoranim.SetActive(true);
    }
}
