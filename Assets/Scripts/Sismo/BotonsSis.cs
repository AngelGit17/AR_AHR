using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonsSis : MonoBehaviour
{
    public GameObject moc;
        public GameObject bot;
        public GameObject luz;
        public GameObject mocIcon;
        public GameObject botIcon;
        public GameObject luzIcon;
        public GameObject Summary;
        public  bool timerfin = false;


    // Start is called before the first frame update
    void Start()
    {
        timerfin = false;
    }

public void ButtonMoc(){
        moc.SetActive(false);
        mocIcon.SetActive(true);
}
public void ButtonBot(){
        bot.SetActive(false);
        botIcon.SetActive(true);
}
public void ButtonLuz(){
        luz.SetActive(false);
        luzIcon.SetActive(true);
}
public void Salida(){
        Summary.SetActive(true);
        timerfin = true;
}
//public void ButtonMen(){
  //  Men.SetActive(true);
//}
}
