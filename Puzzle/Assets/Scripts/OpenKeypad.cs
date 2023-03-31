using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKeypad : MonoBehaviour
{

    public GameObject keypadOB;
    public GameObject keypadText;

    public AudioSource sound;

    public bool inReach;

    void Start(){
        inReach = false;
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Reach"){
            inReach = true;
            keypadText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Reach"){
            inReach = false;
            keypadText.SetActive(false);
        }
    }

    void Update(){
        if(Input.GetButtonDown("Action") && inReach){
            sound.Play();
            keypadOB.SetActive(true);
        }      
    }
}
