using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource[] musicAudioSources; // Массив источников звука музыки
    public Slider volumeSlider; // Слайдер для регулировки громкости
    private const string VolumeKey = "MusicVolume";

    void Start()
    {
        if (volumeSlider != null)
        {
            volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
            float savedVolume = PlayerPrefs.GetFloat(VolumeKey, 1.0f); // Загрузка сохраненной громкости
            volumeSlider.value = savedVolume;
            SetVolume(savedVolume);
        }
    }

    void OnVolumeChanged(float value)
    {
        SetVolume(value);
        PlayerPrefs.SetFloat(VolumeKey, value); // Сохранение громкости
    }

    void SetVolume(float value)
    {
        foreach (var audioSource in musicAudioSources)
        {
            if (audioSource != null)
            {
                audioSource.volume = value;
            }
        }
    }
}
