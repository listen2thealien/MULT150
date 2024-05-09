using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        // Get a reference to the animator
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        anim.SetFloat("Speed", Input.GetAxis("Vertical"));
        anim.SetFloat("Direction", Input.GetAxis("Horizontal"));
    }
}