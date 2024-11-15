using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneReloader : MonoBehaviour
{
    public Button reloadButton; // Ссылка на кнопку

    void Start()
    {
        // Добавляем обработчик события нажатия кнопки
        reloadButton.onClick.AddListener(ReloadScene);
    }

    void ReloadScene()
    {
        // Запускаем корутину для перезагрузки сцены через секунду
        StartCoroutine(ReloadSceneAfterDelay());
    }

    IEnumerator ReloadSceneAfterDelay()
    {
        // Ждем одну секунду
        yield return new WaitForSeconds(1f);

        // Перезагружаем текущую сцену
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

