using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject quitWarning;
    [SerializeField] private GameObject backgroundMusic;
    private Button potionPage;
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
        backgroundMusic.GetComponent<AudioSource>().Pause();
				pausePanel.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        //Disable scripts that still work while timescale is set to 0
    }
    public void ContinueGame()
    {
        isPaused = false;
        backgroundMusic.GetComponent<AudioSource>().UnPause();
				pausePanel.SetActive(false);
				Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        //enable the scripts again
    }
    public void GemGet()
    {
      PauseGame();
      potionPage = GameObject.Find("Button_Potions").GetComponent<Button>();
      potionPage.onClick.Invoke();
      potionPage = GameObject.Find("to-bounce").GetComponent<Button>();
      potionPage.onClick.Invoke();

    }
}
