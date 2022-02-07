using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]

public class SoundPlay : MonoBehaviour
{
    private AudioSource _audio;
    public AudioClip clip;
    [Min(0)]
    public float Volume;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }
    void OnEnable()
    {
        _audio.PlayOneShot(clip, Volume);
    }
    private void OnDisable()
    {
        _audio.Stop();
        
    }

}
