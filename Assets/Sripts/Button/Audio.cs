using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider; // Слайдер для регулировки громкости
    public AudioSource[] audioSources; // Массив AudioSource, громкость которых нужно регулировать
    private static float currentVolume = 1.0f; // Статическая переменная для хранения текущего значения громкости

    private void Start()
    {
        if (volumeSlider != null)
        {
            // Устанавливаем значение слайдера на текущее значение громкости
            volumeSlider.value = currentVolume;

            // Устанавливаем громкость для всех AudioSource
            SetVolume(currentVolume);

            // Добавляем обработчик изменения значения слайдера
            volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        }
    }

    private void OnVolumeChanged(float value)
    {
        // Обновляем текущее значение громкости
        currentVolume = value;

        // Устанавливаем громкость для всех AudioSource
        SetVolume(value);
    }

    private void SetVolume(float value)
    {
        if (audioSources != null && audioSources.Length > 0)
        {
            foreach (var audioSource in audioSources)
            {
                if (audioSource != null)
                {
                    audioSource.volume = value;
                }
            }
        }
    }
}
