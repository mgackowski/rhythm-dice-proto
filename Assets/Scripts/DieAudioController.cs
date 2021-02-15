﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieAudioController : MonoBehaviour
{
    public AudioSource melodyAudioSource;
    public AudioSource soundAudioSource;

    public AudioClip[] melodyClips;
    public AudioClip bounceClip;
    public AudioClip damageClip;
    public AudioClip hitClip;

    public enum SoundEffect
    {
        Rebound, DealDamage, TakeDamage
    }

    public void PlayBeat(int value)
    {
        melodyAudioSource.clip = melodyClips[value];
        melodyAudioSource.Play();
    }
    public void PlaySound(SoundEffect sound)
    {
        AudioClip clipToPlay = null;
        switch (sound)
        {
            case SoundEffect.Rebound:
                clipToPlay = bounceClip;
                break;
            case SoundEffect.DealDamage:
                clipToPlay = hitClip;
                break;
            case SoundEffect.TakeDamage:
                clipToPlay = damageClip;
                break;
        }
        if (clipToPlay != null) {
            soundAudioSource.clip = clipToPlay;
            soundAudioSource.Play();
        }
    }

}