using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float speed = 6f; // Speed of movement

    private float mouseX; // Accumulated mouse input on the X-axis
    private float mouseY; // Accumulated mouse input on the Y-axis

    // Update is called once per frame
    void Update()
    {
        // Accumulate mouse input
        mouseX += Input.GetAxis("Mouse X") * speed;
        mouseY += Input.GetAxis("Mouse Y") * speed;

        // Apply accumulated mouse input to camera position
        transform.position += new Vector3(mouseX, mouseY, 0f);

        // Reset accumulated mouse input
        mouseX = 0f;
        mouseY = 0f;
    }
}