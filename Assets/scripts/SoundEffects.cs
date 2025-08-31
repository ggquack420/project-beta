using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx;

    public void GemSound()
    {
        if (src != null && sfx != null)
        {
            src.clip = sfx;
            src.Play();
        }
    }
}

