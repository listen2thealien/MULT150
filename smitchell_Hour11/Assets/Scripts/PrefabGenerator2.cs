using UnityEngine;

public class PrefabGenerator2 : MonoBehaviour
{
    public GameObject TheGreatEyeballVariant3;
    public Vector3 spawnRange;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = new Vector3(-85.09f, 21.6f, 50.6f);
        Quaternion rotation = Quaternion.Euler(29.89f, 133.2f, -1.855f);

        GameObject instantiatedObject = Instantiate(TheGreatEyeballVariant3, position, rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}