using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoaderWithDelay : MonoBehaviour
{
    // ����� �������� ����� ��������� �� ��������� �����
    public float delay = 5f;

    // ������ �� ������
    public Button loadButton;

    void Start()
    {
        // ��������� ���������� ������� ������
        if (loadButton != null)
        {
            loadButton.onClick.AddListener(LoadNextSceneWithDelay);
        }
    }

    void LoadNextSceneWithDelay()
    {
        // ������ �������� ��� �������� �� ��������� ����� ����� �������� �����
        StartCoroutine(LoadNextSceneAfterDelay());
    }

    IEnumerator LoadNextSceneAfterDelay()
    {
        // ���� �������� �����
        yield return new WaitForSeconds(delay);

        // �������� ������� ������ �����
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // ��������, ���������� �� ��������� �����
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.LogWarning("There is no next scene to load.");
        }
    }
}
