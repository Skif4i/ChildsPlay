using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    // Время задержки перед проигрыванием звука
    public float delay = 5f;

    // Ссылка на AudioSource компонент
    public AudioSource audioSource;

    void Start()
    {
        // Запуск корутины для проигрывания звука через заданное время
        StartCoroutine(PlaySoundAfterDelay());
    }

    IEnumerator PlaySoundAfterDelay()
    {
        // Ждем заданное время
        yield return new WaitForSeconds(delay);

        // Проигрываем звук
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource is not assigned.");
        }
    }
}
