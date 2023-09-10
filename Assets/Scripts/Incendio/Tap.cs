
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour
{   
    public GameObject coll1;
    public GameObject coll2;
    public GameObject coll3;

    public GameObject extintor;
    public GameObject extintor1;
    public GameObject extintor2;

    public GameObject extinv;
    public GameObject extinv1;
    public GameObject extinv2;
    
    public GameObject extintoranim;
    public GameObject extintoranim1;
    public GameObject extintoranim2;

    public GameObject XIcon;
    public GameObject Aviso;
    
    
    public bool ActBut = true;
    /// <summary>

    /// </summary>


    private float elapsed = 0f;
    bool timeron = false;
    bool timerfin = false;

    

    // Start is called before the first frame update
    void Start()
    {
        timeron=false;
        timerfin=false;
        ActBut=true;
    }

    public void Update(){
        for (float f = 5f; f >= 0; f -= 0.1f) {
    }
    if(!coll1.activeSelf||!coll2.activeSelf||!coll3.activeSelf){
         print("hello");   
        }
    }

    void FixedUpdate(){
        if(timeron == true){
        elapsed += Time.deltaTime;
     if (elapsed >= 5f) {
         elapsed = elapsed % 5f;
        XIcon.SetActive(true);
        extinv.SetActive(false);
        extinv1.SetActive(false);
        extinv2.SetActive(false);
        timerfin=true;
     }}
    }

    // Update is called once per frame
    public void ButtonExt(){
        extintor.SetActive(false);
        extinv.SetActive(true);
        coll2.SetActive(false);
        coll1.SetActive(false);
        Aviso.SetActive(true);
        ActBut=false;
    }
    public void ButtonExtOn(){
        timeron=true;
        extintoranim.SetActive(true);
    }

    ////
    public void ButtonExt1(){
        extintor1.SetActive(false);
        extinv1.SetActive(true);
        coll2.SetActive(false);
        Aviso.SetActive(true);
        coll3.SetActive(false);
        ActBut=false;
    }
    public void ButtonExtOn1(){
        timeron=true;
        extintoranim1.SetActive(true);
    }

    ////
    public void ButtonExt2(){
        extintor2.SetActive(false);
        extinv2.SetActive(true);
        coll1.SetActive(false);
        coll3.SetActive(false);
        Aviso.SetActive(true);
        ActBut=false;
    }
    public void ButtonExtOn2(){
        timeron=true;
        extintoranim2.SetActive(true);
    }


    ///
    public void Xbutton(){
        if(timerfin==true){
        extintoranim.SetActive(false);
        extintoranim1.SetActive(false);
        extintoranim2.SetActive(false);
        XIcon.SetActive(false);
        
        }
    }


    ///// Return
    ///
    public void ButtonReg(){
        extintor.SetActive(true);
        extinv.SetActive(false);
        coll2.SetActive(true);
        coll1.SetActive(true);
        ActBut=true;
    }
    public void ButtonReg1(){
        extintor1.SetActive(true);
        extinv1.SetActive(false);
        coll2.SetActive(true);
        coll3.SetActive(true);
        ActBut=true;
    }
    public void ButtonReg2(){
        extintor2.SetActive(true);
        extinv2.SetActive(false);
        coll1.SetActive(true);
        coll3.SetActive(true);
        ActBut=true;
    }



}
