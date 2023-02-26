using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class High : MonoBehaviour
{
    public static string highScoreStr;
    public Text highScore;

    void Start ()
    {
        highScore.text = highScoreStr;
    }
}

