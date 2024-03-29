using UnityEngine;

public class DemoScript : MonoBehaviour
{
// Start is called before the first frame update
    void Start()
    {
        int health = 100;

        if (health == 0) // == equal, !- not equal
    {
        Debug.Log("DANGER! Low health");
    }
    else if (health == 100)
    {
        Debug.Log("player is groovin'");
    }
    else
    {
        Debug.Log("player is just alive'");
    }

    }
}