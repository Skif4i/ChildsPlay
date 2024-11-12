using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnButtonClick : MonoBehaviour
{
    // ���� ��� ������ ������ � ����������
    public UnityEngine.UI.Button button;

    // ���� ��� ������ ����� ����� � ����������
    public AudioClip audioClip;

    // ���� ��� ������ ����� ��������� � ����������
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
