using UnityEngine;

public class ActivateSpotlight : MonoBehaviour
{
    public Light spotlight;

    private void Start()
    {
        // Disable the spotlight at the start of the game
        spotlight.enabled = false;
    }

    private void Update()
    {
       // Check if the player presses the "W" button or "up" arrow
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Activate the spotlight when the player plays the game
            spotlight.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Activate the spotlight when the player plays the game
            spotlight.enabled = true;
        }
    }
}