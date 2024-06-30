using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio clips")]
    public AudioClip background;
    public AudioClip DoorOpening;
    public AudioClip Teleport;
    public AudioClip HeavyGear;
    public AudioClip PlayerLand;
    public AudioClip LeverOn;
    public AudioClip LeverOff;
    public AudioClip SlimeDamaged;
    public AudioClip SlimeMove;
    public AudioClip StoneSlide;
    public AudioClip StoneHitWall;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
        SFXSource.PlayDelayed(5);
    }

    public void PlaySFX2(AudioClip clip)
    {
        SFXSource.PlayDelayed(5);
        SFXSource.PlayOneShot(clip);
        SFXSource.PlayDelayed(5);
    }
}
