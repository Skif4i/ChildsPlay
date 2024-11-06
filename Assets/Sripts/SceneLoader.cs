using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoaderWithDelay : MonoBehaviour
{
    // Время задержки перед переходом на следующую сцену
    public float delay = 5f;

    // Ссылка на кнопку
    public Button loadButton;

    void Start()
    {
        // Добавляем обработчик нажатия кнопки
        if (loadButton != null)
        {
            loadButton.onClick.AddListener(LoadNextSceneWithDelay);
        }
    }

    void LoadNextSceneWithDelay()
    {
        // Запуск корутины для перехода на следующую сцену через заданное время
        StartCoroutine(LoadNextSceneAfterDelay());
    }

    IEnumerator LoadNextSceneAfterDelay()
    {
        // Ждем заданное время
        yield return new WaitForSeconds(delay);

        // Получаем текущий индекс сцены
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Проверка, существует ли следующая сцена
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
