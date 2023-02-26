using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public InputField PlayerName;
    public void GetInput(string Name) 
    {
        NameS1.PlayerNameStr = Name;
        Debug.Log (Name); 
    }
}

