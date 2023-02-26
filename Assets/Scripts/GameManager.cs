using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;
    public Text text;
    public static int Lives = 5;

    public Animator animator;

    void Update ()
    {
        text.text = "Lives: " + Lives.ToString();        
    }
    public void EndGame ()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");
        gameHasEnded = true;         
    }
    public void RestartLevel ()
    {
        if (Lives > 1)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Lives = Lives - 1;
        }
        else
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);            
        }
    }
}
