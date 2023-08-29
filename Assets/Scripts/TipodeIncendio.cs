using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipodeIncendio : MonoBehaviour
{
    public GameObject Inc1;
    public GameObject Inc2;
    public GameObject Inc3;
    private float elapsed = 0f;
    int value;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start(){
        int randomNumber = Random.Range(1, 4);
        value = randomNumber;
        print(randomNumber);
        if(value == 1){
        Inc1.SetActive(true);
        print("Incendio tipo A");
     }
     else if (value==2){
        Inc2.SetActive(true);
        print("Incendio tipo B");
     }
     else if (value==3){
        Inc3.SetActive(true);
        print("Incendio tipo C");
     }
    }
    void Update(){
        for (float f = 5f; f >= 0; f -= 0.1f) {
    }
    }
    void FixedUpdate()
    {
        
    }
}
