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
    public GameObject notesMenu;

    public GameObject note01;
    public GameObject note02;
    public GameObject note03;
    public GameObject note04;
    
    public AudioSource buttonSound;

    private bool on;
    private bool off;

    void Start(){
        menu.SetActive(false);
        notesMenu.SetActive(false);
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
        notesMenu.SetActive(false);
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
        notesMenu.SetActive(true);
    }

    public void Menu(){
        buttonSound.Play();
        if(note01.activeInHierarchy == true || note02.activeInHierarchy == true || note03.activeInHierarchy || note04.activeInHierarchy == true){
            note01.SetActive(false);
            note02.SetActive(false);
            note03.SetActive(false);
            note04.SetActive(false);
        }else{
            menu.SetActive(true);
            notesMenu.SetActive(false);
        }
    }

    public void OpenNote01(){
        if(note01.activeInHierarchy == true || note02.activeInHierarchy == true || note03.activeInHierarchy || note04.activeInHierarchy == true){
            note01.SetActive(false);
            note02.SetActive(false);
            note03.SetActive(false);
            note04.SetActive(false);
        }
        note01.SetActive(true);
        note02.SetActive(false);
        note03.SetActive(false);
        note04.SetActive(false);
    }

    public void OpenNote02(){
        note01.SetActive(false);
        note02.SetActive(true);
        note03.SetActive(false);
        note04.SetActive(false);
    }

    public void OpenNote03(){
        note01.SetActive(false);
        note02.SetActive(false);
        note03.SetActive(true);
        note04.SetActive(false);
    }

    public void OpenNote04(){
        note01.SetActive(false);
        note02.SetActive(false);
        note03.SetActive(false);
        note04.SetActive(true);
    }
}
