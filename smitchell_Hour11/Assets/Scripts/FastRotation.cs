using UnityEngine;

public class FastRotation : MonoBehaviour
{
    public float rotationSpeed = 100f; // Speed of rotation

    // Update is called once per frame
    void Update()
    {
        // Quickly rotate the object around the X-axis
        transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
    }
}