using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance {  get; private set; }
    private AudioSource source;

    private void awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
    }
    public void Playsound(AudioClip _sound)
    {
        source.PlayOneShot(_sound);
    }

}
