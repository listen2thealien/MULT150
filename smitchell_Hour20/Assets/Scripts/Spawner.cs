using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject obstaclePrefab;
    public float spawnCycle = 0.5f;

    private GameManager manager;
    private float elapsedTime;
    private bool spawnPowerup = true;

    private void Start()
    {
        manager = GetComponent<GameManager>();
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnCycle)
        {
            GameObject temp;
            if (spawnPowerup)
                temp = Instantiate(powerupPrefab) as GameObject;
            else
                temp = Instantiate(obstaclePrefab) as GameObject;

            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            temp.transform.position = position;

            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;

            elapsedTime = 0f;
            spawnPowerup = !spawnPowerup;
        }
    }
}