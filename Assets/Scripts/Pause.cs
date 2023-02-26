using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pause : MonoBehaviour
{
    public Text PausedText;
    public Button resumeButton;
    public static bool isPaused = false;

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.P))
        {
            if(isPaused)
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
        Time.timeScale = 0;
        isPaused = true;
        PausedText.gameObject.SetActive(true);
        resumeButton.gameObject.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        PausedText.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(false);
    }
}
