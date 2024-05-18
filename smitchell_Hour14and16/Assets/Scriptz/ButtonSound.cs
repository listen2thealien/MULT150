using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioClip pressSound;
    public AudioClip hoverSound;
    public AudioClip musicClip;
    private AudioSource audioSource;
    private bool isMusicPlaying = true;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musicClip;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlayPressSound()
    {
        audioSource.PlayOneShot(pressSound);
    }

    public void PlayHoverSound()
    {
        audioSource.PlayOneShot(hoverSound);
    }

    public void ToggleMusic()
    {
        isMusicPlaying = !isMusicPlaying;

        if (isMusicPlaying)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
}