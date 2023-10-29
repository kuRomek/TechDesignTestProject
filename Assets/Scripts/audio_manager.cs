using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class audio_manager : MonoBehaviour
{
    public AudioSource music_source;
    public AudioClip[] music_clips;

    public AudioSource sfx_source;
    public AudioClip sfx_clip;

    private void Start()
    {
        sfx_source.clip = sfx_clip;
        sfx_source.Play();
        if (SceneManager.GetActiveScene().name == "day")
        {
            music_source.clip = music_clips[0];
            music_source.Play();
        }
        else
        {
            music_source.clip = music_clips[1];
            music_source.Play();
        }
    }
}
