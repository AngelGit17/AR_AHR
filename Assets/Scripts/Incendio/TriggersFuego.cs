using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TriggersFuego : MonoBehaviour
{
    public GameObject fuego1;
    public GameObject fuego2;
    public GameObject fuego3;
    public GameObject imag1;
    public GameObject imag2;
    public GameObject imag3;
    public GameObject collcanv;
    
    
    public GameObject canvinfo;
    public GameObject canvinfo1;
    

    bool timeron=false;
    private float elapsed = 0f;

    //public Text text1;

    // Start is called before the first frame update
    void Start()
    {
    timeron=false;
    }
    void Update(){
        for (float f = 5f; f >= 0; f -= 0.1f) {
    }
        }
    void FixedUpdate(){
        if(timeron == true){
        elapsed += Time.deltaTime;
     if (elapsed >= 3f) {
         elapsed = elapsed % 3f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
            }
        }
    }
    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "reticula"){

        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        //SceneManager.LoadScene("Loading screen");
        if(fuego1.activeSelf){
            if(imag3.activeSelf){
                canvinfo1.SetActive(true);
                timeron=true;
            }
            else if(imag2.activeSelf || imag1.activeSelf){
                canvinfo.SetActive(true);
            }
        }
        if(fuego2.activeSelf || fuego3.activeSelf){
            if(imag1.activeSelf ){
                canvinfo1.SetActive(true);
                timeron=true;
            }
            else if(imag2.activeSelf || imag3.activeSelf){
                canvinfo.SetActive(true);
            }
        }
        //if(fuego3.activeSelf){
          //  if(imag2.activeSelf || imag1.activeSelf){
            //    print("extintor equivocado, reiniciando");
              //  timeron=true;
            //}
            //else if(imag3.activeSelf){
              //  print("extintor correcto.");
            //}
        //}
        }
    }
}
