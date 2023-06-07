using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseM2 : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    public KeyCode pauseButton = KeyCode.P;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pauseButton))
        {
            if (isPaused)
            {
                ResumeGame();
                
            }
            else
            {
                PauseGame();
            }

        }
        
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        //show cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        //hide cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isPaused = false;
    }
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene((int)SceneIndexes.LobbyMaze1Complete);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
