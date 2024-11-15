using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneReloader : MonoBehaviour
{
    public Button reloadButton; // ������ �� ������

    void Start()
    {
        // ��������� ���������� ������� ������� ������
        reloadButton.onClick.AddListener(ReloadScene);
    }

    void ReloadScene()
    {
        // ��������� �������� ��� ������������ ����� ����� �������
        StartCoroutine(ReloadSceneAfterDelay());
    }

    IEnumerator ReloadSceneAfterDelay()
    {
        // ���� ���� �������
        yield return new WaitForSeconds(1f);

        // ������������� ������� �����
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

