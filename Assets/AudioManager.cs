using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip hit;
    public AudioSource _audiosource;

    private void Start()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        Move.CoinCollectedNotification += PlayAudio;
    }

    private void PlayAudio()
    {
        _audiosource.PlayOneShot(hit);
    }

    private void OnDisable()
    {
        Move.CoinCollectedNotification -= PlayAudio;
    }
}
