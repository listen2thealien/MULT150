using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    public float amplitude = 1.0f; // How far the object will move back and forth
    public float frequency = 1.0f; // How fast the object will move back and forth

    private void Update()
    {
        // Calculate the new z position based on a sine wave
        float newZ = transform.position.z + amplitude * Mathf.Sin(Time.time * 2 * Mathf.PI * frequency);

        // Update the object's position
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
    }
}