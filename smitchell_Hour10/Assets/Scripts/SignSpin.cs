using UnityEngine;

public class SignSpin : MonoBehaviour
{
    public float rotationSpeed = 100f;

    private void Update()
    {
        // Rotate the sign around the X-axis
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
    }
}