using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public float speed = .5f; // Speed of sphere movement

    private Rigidbody rb; // Reference to the Rigidbody component

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to the sphere
    }

    private void Update()
    {
        // Get input from arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Apply movement to the sphere
        rb.AddForce(movement * speed);
    }
}