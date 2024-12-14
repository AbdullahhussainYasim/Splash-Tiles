using UnityEngine;

public class GameMusicPlayer : MonoBehaviour
{
    public AudioSource audioSource; 
    public AudioClip audioSource12;

    public void Start()
    {
        if(MusicSelector.check == 1)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = MusicSelector.selectedMusic;
            audioSource.Play();
        }
        else
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = audioSource12;
            audioSource.Play();
        }

    }

}
