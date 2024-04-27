using UnityEngine;

public class PrefabGenerator3 : MonoBehaviour
{
    public GameObject SmallEyeball;
    public Vector3 spawnRange;

    // Start is called before the first frame update
    void Start()
    {
        float interval = spawnRange.x * 2f / 9f; // Calculate the interval between spawns
        
        for (int i = 0; i < 10; i++)
        {
            float xPosition = -spawnRange.x + (interval * i); // Calculate the x position
            
            Vector3 spawnPosition = new Vector3(xPosition, 1f, 0f); // Set the spawn position
            spawnPosition += new Vector3(-17.9f, 25f, 2.1f); // Adjust the spawn position
            
            Quaternion spawnRotation = Quaternion.Euler(85.4f, 0f, 0f); // Set the spawn rotation
            
            Instantiate<GameObject>(SmallEyeball, spawnPosition, spawnRotation);
        }
    }
}