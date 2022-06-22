using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma
{
    public int municao;
    public float tempoRecarga;
    public string nomeArma;
    public GameObject objetoArma;
    public bool isReady;


    public Arma(string nome, float recarga, int qtdeBalas){
        nomeArma = nome;
        recarga = tempoRecarga;
        qtdeBalas = municao;
    }

    public void PegarArma(GameObject arma, bool dropped, GameObject attachedUser){
        
        if(dropped){
            arma.GetComponent<BoxCollider>().enabled = true;
            arma.transform.eulerAngles = new Vector3(90f,0f,0f);
            attachedUser = null;
        }
        else{
            Debug.Log("Pegou Arma");
            arma.GetComponent<BoxCollider>().enabled = false;
            arma.GetComponent<Rigidbody>().isKinematic = true; 
            Debug.Log(attachedUser.name);
            arma.transform.localPosition = new Vector3(1f,0.5f,-0.5f);
            //arma.transform.localEulerAngles = attachedUser/*.gameObject.transform.GetChild(0)*/.transform.eulerAngles;
            arma.transform.parent = attachedUser.transform;//.gameObject.transform.GetChild(0).transform;
            arma.transform.localEulerAngles = new Vector3(0,0,0);
            
                      
        }
    }

   // public void Atirar(){
   // }
}
