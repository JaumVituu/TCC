using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador
{
    int vida = 100;
    float velocidade;
    public string name;
    float MouseY, MouseX;

    public Jogador(string objectName){
        name = objectName;
    }
    
    public void Movimenta(GameObject player, Camera playerCam){
        Cursor.lockState = CursorLockMode.Locked;
        if(Input.GetKey(KeyCode.W)){
            velocidade = 7.5f;
            player.transform.Translate(velocidade*Time.deltaTime,0f,0f);
            velocidade = 0.0f;
            Debug.Log("Andou");
        }

        if(Input.GetKey(KeyCode.S)){
            velocidade = 7.5f;
            player.transform.Translate(-velocidade*Time.deltaTime,0f,0f);
            velocidade = 0.0f;
            Debug.Log("Andou");
        }

        if(Input.GetKey(KeyCode.A)){
            velocidade = 7.5f;
            player.transform.Translate(0f,0f,velocidade*Time.deltaTime);
            velocidade = 0.0f;
            Debug.Log("Andou");
        }

        if(Input.GetKey(KeyCode.D)){
            velocidade = 7.5f;
            player.transform.Translate(0f,0f,-velocidade*Time.deltaTime);
            velocidade = 0.0f;
            Debug.Log("Andou");
        }

        if(MouseY <= 90f && MouseY >= -90f){
            MouseY += Input.GetAxis("Mouse Y");        
        }
        if(MouseY >= 90f && Mathf.Abs(Input.GetAxis("Mouse Y"))/-Input.GetAxis("Mouse Y") == 1){
            //Debug.Log("Sinal invertido do angulo = " + Input.GetAxis("Mouse Y")/-Input.GetAxis("Mouse Y"));
            MouseY += Input.GetAxis("Mouse Y");
        }
      
        if(MouseY <= -90f && Mathf.Abs(Input.GetAxis("Mouse Y"))/-Input.GetAxis("Mouse Y") == -1){
           // Debug.Log("Sinal invertido do angulo = " + Input.GetAxis("Mouse Y")/-Input.GetAxis("Mouse Y"));
            MouseY += Input.GetAxis("Mouse Y");
        }

        MouseX += Input.GetAxis("Mouse X")*2;
        //Debug.Log("X = "+MouseY+", Y = "+MouseX);
        player.transform.eulerAngles = new Vector3(0f,MouseX,0f);
        playerCam.transform.eulerAngles = player.transform.eulerAngles + new Vector3(-MouseY,90f,0f);

    }
}
