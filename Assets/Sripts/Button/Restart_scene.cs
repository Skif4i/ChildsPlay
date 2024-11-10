using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartSceneAfterDelay : MonoBehaviour
{
    public Button restartButton; // ������ ��� ����������� �����
    public float delay = 1f; // �������� � ��������

    private void Start()
    {
        if (restartButton != null)
        {
            restartButton.onClick.AddListener(OnButtonClick);
        }
    }

    private void OnButtonClick()
    {
        Invoke("RestartScene", delay);
    }

    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
