using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSceneOnButtonClick : MonoBehaviour
{
    public Button loadButton; // ������ ��� �������� �� ������ �����
    public string sceneName; // ��� �����, ������� ������ ���� ���������

    private void Start()
    {
        if (loadButton != null)
        {
            loadButton.onClick.AddListener(OnButtonClick);
        }
    }

    private void OnButtonClick()
    {
        LoadScene();
    }

    private void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is not set in the inspector.");
        }
    }
}
