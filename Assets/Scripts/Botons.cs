using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botons : MonoBehaviour
{
    public GameObject Inc;
    public GameObject Sis;
    public GameObject Men;

    // Start is called before the first frame update
    void Start()
    {
        
    }

public void ButtonInc(){
    Inc.SetActive(true);
    Sis.SetActive(false);
    Men.SetActive(false);
}
public void ButtonSism(){
    Sis.SetActive(true);
    Inc.SetActive(false);
    Men.SetActive(false);
}
public void ButtonMen(){
    Men.SetActive(true);
}
}
