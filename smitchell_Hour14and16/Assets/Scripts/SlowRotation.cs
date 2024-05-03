using UnityEngine;

public class SlowRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; // Speed of rotation

    // Update is called once per frame
    void Update()
    {
        // Slowly rotate the object around the X-axis
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
    }
}