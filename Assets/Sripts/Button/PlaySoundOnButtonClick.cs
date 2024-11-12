using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnButtonClick : MonoBehaviour
{
    // Поле для выбора кнопки в инспекторе
    public UnityEngine.UI.Button button;

    // Поле для выбора аудио клипа в инспекторе
    public AudioClip audioClip;

    // Поле для выбора аудио источника в инспекторе
    public AudioSource audioSource;

    void Start()
    {
        if (button != null)
        {
            button.onClick.AddListener(PlaySound);
        }
    }

    void PlaySound()
    {
        if (audioClip != null && audioSource != null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}
