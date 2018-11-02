using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject quitWarning;
    static bool isPaused = false;

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Escape))
        {
            if (!isPaused)
            {
                PauseGame();
            }
            else if (isPaused)
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
        isPaused = true;
				pausePanel.SetActive(true);
        Time.timeScale = 0;

        //Disable scripts that still work while timescale is set to 0
    }
    public void ContinueGame()
    {
        isPaused = false;
				pausePanel.SetActive(false);
				Time.timeScale = 1;

        //enable the scripts again
    }
}
