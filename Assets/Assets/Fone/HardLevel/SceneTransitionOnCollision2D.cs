using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionOnCollision2D : MonoBehaviour
{
    public string nextSceneName; // ��� ����� ��� ��������

    void OnCollisionEnter2D(Collision2D collision)
    {
        // ���������, ���� �� ��� ��������� �����
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            // ��������� �� ��������� �����
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
