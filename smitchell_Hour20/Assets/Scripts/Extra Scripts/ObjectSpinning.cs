using UnityEngine;

public class ObjectSpinning : MonoBehaviour
{
    public float rotationSpeed = 41.97f;  // Speed of rotation in degrees per second

    private void Update()
    {
        // Rotate the object around its local Y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}