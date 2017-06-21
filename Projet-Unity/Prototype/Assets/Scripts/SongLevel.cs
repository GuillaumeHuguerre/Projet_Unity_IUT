using UnityEngine;
using System.Collections;

public class SongLevel : MonoBehaviour {


    public AudioClip[] clip = new AudioClip[8];
    public AudioSource source;

    public void PlaySting()
    {
        int randClip = Random.Range(0, clip.Length);
        source.clip = clip[randClip];
        source.Play();
    }
}
