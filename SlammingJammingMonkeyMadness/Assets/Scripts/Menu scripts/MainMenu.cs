using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{  public GameObject UI;
    public GameObject background;
    public GameObject hearts;
    public GameObject player;
    public GameObject gameMusic;
    public GameObject menuMusic;
    public GameObject loadingMenu;
        
    public void Start()
    {
        
    }
    public void Update()
    {
        if(background.activeSelf)
        {
            GameMenu();
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
    public void LoadingGameVoid()
    {
        LoadingGame();
        Debug.Log("Works");
    }
    public IEnumerator LoadingGame()
    {
        Debug.Log("also works");
        yield return new WaitForSeconds(5);
        background.SetActive(false);
        loadingMenu.SetActive(false);
    }
}
