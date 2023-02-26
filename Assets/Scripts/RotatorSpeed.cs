using UnityEngine;
using UnityEngine.UI;
public class RotatorSpeed : MonoBehaviour
{
    public Slider RotatorSpeedSlider;
    public Text RotatorSpeedText;
    public static float Rotatorspeed;

    void Update ()
    {
        Rotatorspeed = RotatorSpeedSlider.value;
        RotatorSpeedText.text = Rotatorspeed.ToString("f0");
    }
}
