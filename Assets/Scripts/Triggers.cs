using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Triggers : MonoBehaviour
{
    public GameObject imag1;

    public Tap boton;
    public GameObject bot1;
    public GameObject bot2;

    //public Text text1;

    // Start is called before the first frame update
    void Start()
    {
        boton = FindObjectOfType<Tap>();
    }
    void Update(){
        

        }
    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "reticula"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        //SceneManager.LoadScene("Loading screen");
        imag1.SetActive(true);
        if(boton.ActBut == true){
            bot1.SetActive(true);
        }
        else if(boton.ActBut == false){
            bot2.SetActive(true);
        }
        bot1.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider others)
    {
        imag1.SetActive(false);
        bot1.SetActive(false);
        bot2.SetActive(false);
    }
}
