using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    Light lightComponent;
    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "LTrigger")
        {
            print("Sphere has entered LTrigger");
        }
        else if (other.gameObject.name == "RTrigger")
        {
            print("Sphere has entered RTrigger");
        }
        lightComponent.enabled = !lightComponent.enabled;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "LTrigger")
        {
            print("Sphere is still in LTrigger");
        }
        else if (other.gameObject.name == "RTrigger")
        {
            print("Sphere is still in RTrigger");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "LTrigger")
        {
            print("Sphere has left LTrigger");
        }
        else if (other.gameObject.name == "RTrigger")
        {
            print("Sphere has left RTrigger");
        }
    }
}