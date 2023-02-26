using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinColor : MonoBehaviour
{
    public Dropdown PinColorDropdown;
    public GameObject Pin;

    public void ChangePinColor ()
    {
        switch(PinColorDropdown.value)
        {
            case 0:
                Pin.GetComponent<Renderer>().sharedMaterial.color = Color.blue;
                break;
            case 1:
                Pin.GetComponent<Renderer>().sharedMaterial.color = Color.red;
                break;
            case 2:
                Pin.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                break;
        }
    }   
}
