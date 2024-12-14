using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicSelector : MonoBehaviour
{
    public AudioSource audioSource1; 
    public AudioClip[] musicTracks; 
    public static AudioClip selectedMusic; 
    public static int check = 0;
    public void PlaySelectedMusic(int trackIndex)
    {
        if (trackIndex >= 0 && trackIndex < musicTracks.Length)
        {
            selectedMusic = musicTracks[trackIndex]; 
            audioSource1.clip = selectedMusic;
            audioSource1.Play();
            check = 1;
        }
    }


}
