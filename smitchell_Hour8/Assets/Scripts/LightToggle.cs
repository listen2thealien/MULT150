using UnityEngine;

public class LightToggle : MonoBehaviour
{
    private Light lightComponent; // Reference to the Light component

    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>(); // Get the Light component attached to the same GameObject
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) // Check if 'L' key is pressed
        {
            lightComponent.enabled = !lightComponent.enabled; // Toggle the light on/off
        }
    }
}