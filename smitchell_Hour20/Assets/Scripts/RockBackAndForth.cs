using UnityEngine;

public class RockBackAndForth : MonoBehaviour
{
    public float amplitude = 1.0f; // How much the object will rock back and forth
    public float frequency = 1.0f; // How fast the object will rock back and forth

    private void Update()
    {
        // Calculate the amount of rotation based on sine wave
        float rotation = amplitude * Mathf.Sin(Time.time * 2 * Mathf.PI * frequency);

        // Rotate the object around the z-axis
        transform.localRotation = Quaternion.Euler(0f, 0f, rotation);
    }
}