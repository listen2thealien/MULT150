using UnityEngine;

public class ChaosBall : MonoBehaviour
{
        private void OnTriggerEnter(Collider other)
    {
        // Check if the Chaos Ball collides with a Chaos Goal
        ChaosGoalScript chaosGoal = other.GetComponent<ChaosGoalScript>();
        if (chaosGoal != null)
        {
            // Handle Chaos Goal collision here (e.g., increase score, play sound, etc.)

            // Destroy the Chaos Ball
            Destroy(gameObject);
        }
    }
}