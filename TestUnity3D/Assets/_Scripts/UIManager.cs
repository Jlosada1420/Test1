using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject pausePanel;
    private bool isGamePaused;

    void Start()
    {
        Time.timeScale = 1.0f;
        isGamePaused = false;
    }

    void Update()
    {
        PauseMenu();
    }

    // Método para pausar el juego
    public void PauseMenu()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isGamePaused = !isGamePaused;
            if(isGamePaused)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
            pausePanel.SetActive(isGamePaused);
        }


        
    }
}
