using UnityEngine;

public class Collidable : MonoBehaviour
{
    public GameManager manager;
    public float moveSpeed = 20f;
    public float timeAmount = 1.5f;

    private void Update()
    {
        transform.Translate(0f, 0f, -moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Use CompareTag for tag comparison
        {
            manager.AdjustTime(timeAmount);
            Destroy(gameObject);
        }
    }
}