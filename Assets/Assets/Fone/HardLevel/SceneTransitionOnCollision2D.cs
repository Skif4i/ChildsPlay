using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionOnCollision2D : MonoBehaviour
{
    public string nextSceneName; // Имя сцены для перехода

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Проверяем, есть ли имя следующей сцены
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            // Переходим на следующую сцену
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
