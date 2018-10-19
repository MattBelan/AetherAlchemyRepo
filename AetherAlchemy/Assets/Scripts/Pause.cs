﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject quitWarning;

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Escape))
        {
            if (!pausePanel.activeInHierarchy)
            {
                PauseGame();
            }
            else if (pausePanel.activeInHierarchy)
            {
                if(quitWarning.activeInHierarchy){
                  quitWarning.SetActive(false);
                }
                ContinueGame();
            }
        }
     }
    public void PauseGame()
    {
				pausePanel.SetActive(true);
        Time.timeScale = 0;

        //Disable scripts that still work while timescale is set to 0
    }
    public void ContinueGame()
    {
				pausePanel.SetActive(false);
				Time.timeScale = 1;

        //enable the scripts again
    }
}
