using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmsound : MonoBehaviour
{
    public AudioSource audiosource;
    private float musicvolume = 100f;
    // Start is called before the first frame update
    void Awake()
    {
        audiosource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        audiosource.volume = musicvolume;
    }

    public void updatevolume(float volume)
    {
    musicvolume = volume;
    }
}
