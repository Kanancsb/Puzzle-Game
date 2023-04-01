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
    public GameObject notesM;

    public GameObject noteT;
    
    public AudioSource buttonSound;

    public bool on;
    public bool off;

    void Start(){
        menu.SetActive(false);
        notesM.SetActive(false);
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
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void Resume(){
        buttonSound.Play();
        Time.timeScale = 1;
        menu.SetActive(false);
        notesM.SetActive(false);
        off = true;
        on = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MainMenu(){
        buttonSound.Play();

    }

    public void Exit(){
        buttonSound.Play();
        Application.Quit();
    }

    public void NotesM(){
        buttonSound.Play();
        menu.SetActive(false);
        notesM.SetActive(true);
    }

    public void Menu(){
        buttonSound.Play();
        menu.SetActive(true);
        notesM.SetActive(false);
    }

    public void OpenNote(){
        noteT.SetActive(true);
    }

    public void CloseNote(){
        noteT.SetActive(false);
    }
}
