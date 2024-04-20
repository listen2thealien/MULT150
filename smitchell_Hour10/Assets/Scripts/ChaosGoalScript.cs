using UnityEngine;

public class ChaosGoalScript : MonoBehaviour
{
    public bool isSolved = false;
    public int destroyedChaosBallCount = 0; // Counter for destroyed Chaos Balls

    private void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;

        // Check if the collided object is a Chaos Ball
        ChaosBall chaosBall = collidedWith.GetComponent<ChaosBall>();
        if (chaosBall != null && chaosBall.tag == gameObject.tag)
        {
            isSolved = true;

            // Increment the destroyed Chaos Ball count
            destroyedChaosBallCount++;

            // Print the count
            Debug.Log("Destroyed Chaos Balls: " + destroyedChaosBallCount);

            // Destroy the collided Chaos Ball
            Destroy(collidedWith);
        }
    }
}