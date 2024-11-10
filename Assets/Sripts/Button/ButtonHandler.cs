using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public Button[] buttons; // ������ ������
    public GameObject[] hiddenObjects; // ������ ������� ��������
    public AudioSource audioSource; // �������� �����
    public string nextSceneName; // ��� ��������� �����

    private int buttonsPressed = 0;

    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // ��������� ���������� ��� ������� �������� �������
            buttons[i].onClick.AddListener(() => OnButtonClick(index));
        }

        foreach (var obj in hiddenObjects)
        {
            obj.SetActive(false); // ��������, ��� ��� ������� ������� ���������� ���������
        }
    }

    void OnButtonClick(int index)
    {
        if (index < hiddenObjects.Length)
        {
            hiddenObjects[index].SetActive(true); // ���������� ������� ������
        }

        buttonsPressed++;

        if (buttonsPressed == buttons.Length)
        {
            PlaySound();
            Invoke("LoadNextScene", 4f); // ����� 4 ������� ������� ����� LoadNextScene
        }
    }

    void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play(); // ����������� ����
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName); // ������� �� ��������� �����
    }
}
