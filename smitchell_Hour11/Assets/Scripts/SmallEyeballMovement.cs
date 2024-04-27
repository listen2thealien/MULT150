using UnityEngine;

public class SmallEyeballMovement : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed of movement
    public float movementRange = 5f; // Total distance to move along X-axis
    private bool movingRight = true; // Flag to track movement direction
    private float initialX; // Initial X position of the SmallEyeball

    // Start is called before the first frame update
    void Start()
    {
        initialX = transform.position.x; // Store the initial X position
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the target position based on the movement direction
        float targetX = movingRight ? initialX + movementRange : initialX - movementRange;

        // Move the SmallEyeball towards the target position
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetX, transform.position.y, transform.position.z), moveSpeed * Time.deltaTime);

        // If the SmallEyeball reaches the target position, change the movement direction
        if (Mathf.Abs(transform.position.x - targetX) < 0.01f)
        {
            movingRight = !movingRight;
        }
    }
}