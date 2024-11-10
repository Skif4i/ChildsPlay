using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    // ����� �������� ����� ������������� �����
    public float delay = 5f;

    // ������ �� AudioSource ���������
    public AudioSource audioSource;

    void Start()
    {
        // ������ �������� ��� ������������ ����� ����� �������� �����
        StartCoroutine(PlaySoundAfterDelay());
    }

    IEnumerator PlaySoundAfterDelay()
    {
        // ���� �������� �����
        yield return new WaitForSeconds(delay);

        // ����������� ����
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
