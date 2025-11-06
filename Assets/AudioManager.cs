using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip backGroundMusic;
    public AudioClip grabSFX;
    public AudioSource musicSource;
    public AudioSource sfxSource;
    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = backGroundMusic;
        musicSource.Play();
        musicSource.loop = true;
        sfxSource.clip = grabSFX;
    }


    public void PlayGrab()
    {
        sfxSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
