using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{

    public GameObject menu;
    public GameObject resume;
    public GameObject quit;
    public GameObject mainMenu;
    
    public AudioSource buttonSound;

    public bool on;
    public bool off;

    void Start(){
        menu.SetActive(false);
        off = true;
        on = false;
    }

    void Update(){
        if(off && Input.GetKeyDown(KeyCode.Escape)){
            Time.timeScale = 0;
            menu.SetActive(true);
            off = false;
            on = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }else if(on && Input.GetKeyDown(KeyCode.Escape)){
            Time.timeScale = 1;
            menu.SetActive(false);
            off = true;
            on = false;
            Cursor.visible = false;
        }
    }

    public void Resume(){
        buttonSound.Play();
        Time.timeScale = 1;
        menu.SetActive(false);
        off = true;
        on = false;
        Cursor.visible = false;
    }

    public void MainMenu(){
        buttonSound.Play();

    }

    public void Exit(){
        buttonSound.Play();
        Application.Quit();
    }
}
