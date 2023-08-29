using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botons : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

public void ButtonInc(){
        SceneManager.LoadScene("Incendio");
}
public void ButtonSism(){
        SceneManager.LoadScene("Sismo"); 
}
//public void ButtonMen(){
  //  Men.SetActive(true);
//}
}
