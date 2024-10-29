using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashlight;
    public AudioSource lightSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleFlashlight();
        }
    }

    void ToggleFlashlight()
    {
        flashlight.enabled = !flashlight.enabled;
        lightSound.Play();
    }
}
