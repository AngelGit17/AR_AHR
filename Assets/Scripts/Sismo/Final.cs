using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
        public GameObject FinCan;
        public GameObject mocIcon;
        public GameObject botIcon;
        public GameObject luzIcon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mocIcon.activeSelf && botIcon.activeSelf && luzIcon.activeSelf){
            print("hello");
            FinCan.SetActive(true);

        }
    }
}
