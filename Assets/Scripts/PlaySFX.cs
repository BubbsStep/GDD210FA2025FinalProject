using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlayAttackSFX()
    {
        audioSource.Play(); 
    }
}
