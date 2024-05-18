using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    public float radius = 2f;
    public float speed = 1f;

    private void Update()
    {
        // Calculate the position on the circle based on the current time
        float angle = Time.time * speed;
        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;

        // Set the position of the game object
        transform.position = new Vector3(x, y, transform.position.z);
    }
}