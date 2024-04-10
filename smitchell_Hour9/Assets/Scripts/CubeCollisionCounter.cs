using UnityEngine;

public class CubeCollisionCounter : MonoBehaviour
{
    private int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {
            collisionCount++;
            Debug.Log("Collision Count: " + collisionCount);
        }
    }
}