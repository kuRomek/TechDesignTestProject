using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class change_scene : MonoBehaviour
{
    public AudioSource voice_source;
    public AudioClip[] voice_clips;

    private void change()
    {
        if (SceneManager.GetActiveScene().name == "day")
        {
            SceneManager.LoadScene("night", LoadSceneMode.Single);
        }
        else if (SceneManager.GetActiveScene().name == "night")
        {
            SceneManager.LoadScene("day", LoadSceneMode.Single);
        }
    }

    public void change_daytime()
    {
        voice_source.clip = voice_clips[Random.Range(0, 2)];
        voice_source.Play();
        Invoke("change", 1);
    }
}