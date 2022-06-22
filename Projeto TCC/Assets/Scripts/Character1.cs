using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character1 : MonoBehaviour
{
    Jogador Char1 = new Jogador("Ronaldo");
    public Camera currentCamera;
    void Start()
    {
             
    }

    // Update is called once per frame
    void Update()
    {
        Char1.Movimenta(gameObject,currentCamera);
    }

    
}
