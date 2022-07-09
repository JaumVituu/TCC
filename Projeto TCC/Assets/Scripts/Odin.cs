using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odin : MonoBehaviour
{
    Jogador Personagem = new Jogador("Odin");
    public Camera currentCamera;
    public GameObject Corvo;
    public bool segurandoCorvo;
    public bool corvoUsado;

    void Start()
    {
        segurandoCorvo = false;
        corvoUsado = false;           
    }

    // Update is called once per frame
    void Update()
    {
        Personagem.Movimenta(gameObject,currentCamera);
        UsarCorvo();      
    }

    void UsarCorvo(){
        float recarcaCorvo;
        float tempoVoo = 3f;
        GameObject habilidadeCorvo;
        Camera cameraCorvo;

        if(corvoUsado == false){
            if(segurandoCorvo == false){
                if(Input.GetKeyDown(KeyCode.E)){
                    segurandoCorvo = true;
                    Debug.Log("pegou corvo");
                }
            }
            else{
                if(Input.GetKeyDown(KeyCode.E)){
                    segurandoCorvo = false;
                    Debug.Log("soltou corvo");
                }
                if(Input.GetMouseButtonDown(0)){
                    habilidadeCorvo = Instantiate(Corvo, transform.position + new Vector3(1,0,0), transform.rotation);
                    corvoUsado = true;
            	}             
            } 
        }               
    }    
}
