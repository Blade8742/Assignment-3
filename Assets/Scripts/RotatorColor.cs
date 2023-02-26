using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatorColor : MonoBehaviour
{    
    public Dropdown RotatorColorDropdown;
    public GameObject Rotator;

    public void ChangeRotatorColor ()
    {
        switch(RotatorColorDropdown.value)
        {
            case 0:
                Rotator.GetComponent<Renderer>().sharedMaterial.color = Color.blue;
                break;
            case 1:
                Rotator.GetComponent<Renderer>().sharedMaterial.color = Color.red;
                break;
            case 2:
                Rotator.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                break;
        }
    }   
}