using UnityEngine;

public class EyeballController : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A)) // Check for "A" key press
        {
            animator.SetTrigger("Recolor");
        }
        if (Input.GetKeyDown(KeyCode.W)) // Check for "W" key press
        {
            animator.SetTrigger("Position");
        }
        if (Input.GetKeyDown(KeyCode.S)) // Check for "s" key press
        {
            animator.SetTrigger("Rotate");
        }
        if (Input.GetKeyDown(KeyCode.D)) // Check for "d" key press
        {
            animator.SetTrigger("Scale");
        }
    }
}