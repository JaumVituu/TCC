using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M16 : MonoBehaviour
{
    Arma m16 = new Arma("M16", 1.0f, 30);
    public GameObject currentUser;
    bool isDropped = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m16.PegarArma(gameObject, isDropped, currentUser);
    }

    void OnCollisionEnter(Collision colisor){
        if(colisor.gameObject.tag == "Player"){
            Debug.Log("OK");
            if(isDropped){
                isDropped = false;
                currentUser = colisor.gameObject;
            }
        }
    }
}
