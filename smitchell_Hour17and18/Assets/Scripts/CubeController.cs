using UnityEngine;

public class CubeController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Rotate");
        }
        if (Input.GetMouseButtonDown(1))
        {
            animator.SetTrigger("Recolor");
        }
    }
}
