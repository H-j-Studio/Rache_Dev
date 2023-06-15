using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource btnSource;

    public void SetMusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SetButtonVolume(float volume)
    {
        btnSource.volume = volume;
    }

    public void OnSfx()
    {
        btnSource.Play();
    }
}
