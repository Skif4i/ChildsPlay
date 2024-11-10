using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider; // ������� ��� ����������� ���������
    public AudioSource[] audioSources; // ������ AudioSource, ��������� ������� ����� ������������
    private static float currentVolume = 1.0f; // ����������� ���������� ��� �������� �������� �������� ���������

    private void Start()
    {
        if (volumeSlider != null)
        {
            // ������������� �������� �������� �� ������� �������� ���������
            volumeSlider.value = currentVolume;

            // ������������� ��������� ��� ���� AudioSource
            SetVolume(currentVolume);

            // ��������� ���������� ��������� �������� ��������
            volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        }
    }

    private void OnVolumeChanged(float value)
    {
        // ��������� ������� �������� ���������
        currentVolume = value;

        // ������������� ��������� ��� ���� AudioSource
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
