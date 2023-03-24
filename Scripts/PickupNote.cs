using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupNote : MonoBehaviour
{
    public GameObject Text;
    public GameObject NoteOB;

    public AudioSource pSound;

    public Transform Player;

    // Update is called once per frame

    void OnMouseOver(){

        if(Player){
            float dist = Vector3.Distance(Player.position, transform.position);
            if (dist < 3){
            Text.SetActive(true);
            }

            if (Input.GetButtonDown("Action")){
                if (dist < 3){
                    Text.SetActive(false);
                    NoteOB.SetActive(true);
                }
            } 
        }
    }

    void OnMouseExit(){
        Text.SetActive(false);        
    }

    void Update(){
        if(Input.GetButtonDown("Drop")){
                NoteOB.SetActive(false);
            } 
    }

}
