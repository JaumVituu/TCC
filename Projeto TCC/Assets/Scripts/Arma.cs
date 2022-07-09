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
        //else{
            
        //}
    }

   // public void Atirar(){
   // }
}
