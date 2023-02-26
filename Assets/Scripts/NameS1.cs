using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NameS1 : MonoBehaviour
{
    public static string PlayerNameStr;
    public Text PlayerName;

    void Start ()
    {
        PlayerName.text = PlayerNameStr;
    }
}

