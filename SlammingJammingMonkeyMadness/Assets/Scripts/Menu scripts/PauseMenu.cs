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
    public GameObject gameMusic;
    public GameObject menuMusic;
    public GameObject mainMenu;

    
    void Update()
    {
        if(background.activeSelf)
        {
            GameMenu();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!background.activeSelf && !mainMenu.activeSelf)
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
        gameMusic.SetActive(false);
        menuMusic.SetActive(true);
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
        gameMusic.SetActive(true);
        menuMusic.SetActive(false);
    }
}
