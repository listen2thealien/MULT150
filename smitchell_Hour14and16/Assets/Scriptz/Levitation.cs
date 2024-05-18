using UnityEngine;

public class Levitation : MonoBehaviour
{
    public float levitationHeight = 1f; // The height at which the DeadBody should levitate
    public float levitationSpeed = 1f; // The speed at which the DeadBody should levitate

    private Rigidbody rb;
    private Vector3 initialPosition;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Calculate the target position for levitation
        Vector3 targetPosition = initialPosition + new Vector3(0f, levitationHeight, 0f);

        // Calculate the direction towards the target position
        Vector3 direction = targetPosition - transform.position;

        // Normalize the direction vector
        direction.Normalize();

        // Apply force to move the object towards the target position
        rb.AddForce(direction * levitationSpeed);

        // Keep the DeadBody's rotation fixed
        rb.angularVelocity = Vector3.zero;
    }
}