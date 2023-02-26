using UnityEngine;
using UnityEngine.UI;
public class PinSpeed : MonoBehaviour
{
    public Slider PinSpeedSlider;
    public Text PinSpeedText;
    public static float Pinspeed;

    void Update ()
    {
        Pinspeed = PinSpeedSlider.value;
        PinSpeedText.text = Pinspeed.ToString("f0");
    }
}
