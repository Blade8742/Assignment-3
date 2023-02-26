using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount;
    public static int highscore;

    public Text text;

    void Start()
    {
        PinCount = 0;   
    }

    void Update()
    {
        text.text = PinCount.ToString();
            if (PinCount > highscore)
            {
                highscore = PinCount;
                High.highScoreStr = highscore.ToString();
            }
    }
}
