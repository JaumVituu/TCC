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
    GameObject habilidadeCorvo;
    Transform cameraCorvo;
    float tempoVoo;
    float recargaCorvo;
    Quaternion rotacaoCorvo;

    void Start()
    {
        segurandoCorvo = false;
        corvoUsado = false;    
        tempoVoo = 3f;
        recargaCorvo = 30f;       
    }


    void Update()
    {
        
        if(currentCamera.GetComponent<Camera>().enabled == true){
            Personagem.Movimenta(gameObject,currentCamera);
        }
        UsarCorvo();      
    }

    void UsarCorvo(){
        rotacaoCorvo = Quaternion.Euler(currentCamera.transform.rotation.x, transform.rotation.y, 0f);
        //rotacaoCorvo = Quaternion.Euler(150,50,0);
        if (corvoUsado){            
            if(tempoVoo >= 0f){
                //habilidadeCorvo.transform.Translate(habilidadeCorvo.transform.forward*Time.deltaTime);
                cameraCorvo = habilidadeCorvo.transform.GetChild(0);
                cameraCorvo.GetComponent<Camera>().enabled = false;
                tempoVoo -= Time.deltaTime;
            }
            else{
                Debug.Log("Acabou voo");
                if(Input.GetKeyDown(KeyCode.E)){
                    cameraCorvo.GetComponent<Camera>().enabled = !cameraCorvo.GetComponent<Camera>().enabled;
                    currentCamera.GetComponent<Camera>().enabled = !currentCamera.GetComponent<Camera>().enabled;
                    recargaCorvo -= Time.deltaTime;
                }                
            }
        }
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
                    habilidadeCorvo = Instantiate(Corvo, transform.position + new Vector3(1,1,0),Quaternion.identity*rotacaoCorvo);
                    Debug.Log((Quaternion)currentCamera.transform.rotation.x + "," + transform.rotation.y);
                    corvoUsado = true;
            	}             
            } 
        }               
    }    
}
