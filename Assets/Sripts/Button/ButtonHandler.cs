using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ButtonHandler : MonoBehaviour
{
    public Button[] buttons; // ������ ������
    public GameObject objectToHide; // ������, ������� ����� ������
    public GameObject objectToReveal; // ������, ������� ����� ����������
    public AudioSource audioSource; // �������� �����
    public string nextSceneName; // ��� ��������� �����
    public bool enableSceneTransition = true; // ���� ��� ���������/���������� �������� �� ��������� �����

    private HashSet<Button> pressedButtons = new HashSet<Button>();
    private int buttonsPressed = 0;

    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // ��������� ���������� ��� ������� �������� �������
            buttons[i].onClick.AddListener(() => OnButtonClick(buttons[index]));
        }

        if (objectToReveal != null)
        {
            objectToReveal.SetActive(false); // ��������, ��� ������� ������ ���������� ���������
        }
    }

    void OnButtonClick(Button button)
    {
        if (!pressedButtons.Contains(button))
        {
            pressedButtons.Add(button);
            buttonsPressed++;

            if (buttonsPressed == buttons.Length)
            {
                PlaySound();
                if (objectToHide != null)
                {
                    objectToHide.SetActive(false); // �������� ������
                }
                if (objectToReveal != null)
                {
                    objectToReveal.SetActive(true); // ���������� ������� ������
                }
                if (enableSceneTransition)
                {
                    Invoke("LoadNextScene", 4f); // ����� 4 ������� ������� ����� LoadNextScene
                }
            }
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
