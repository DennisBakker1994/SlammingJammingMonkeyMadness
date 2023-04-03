using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject UI;
    public GameObject background;
    public GameObject hearts;
    public GameObject pauseMenu;
    public GameObject player;
    
    void Update()
    {
        if(background.activeSelf)
        {
            GameMenu();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!background.activeSelf)
            {
                background.SetActive(true);
                pauseMenu.SetActive(true);
                player.GetComponent<Movement>().enabled = false;
            }
        }
    }
    public void Quit()
    {
        Debug.Log("Quiting game");
        Application.Quit();
    }
    public void GameMenu()
    {
        hearts.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }
    public void LoadGame()
    {
        background.SetActive(false);
    }   
    public void Resume()
    {
        background.SetActive(false);
        pauseMenu.SetActive(false);
        hearts.SetActive(true);
        player.GetComponent<Movement>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
