using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDisplay : MonoBehaviour
{
    // Время задержки перед отображением объекта
    public float delay = 5f;

    // Ссылка на объект, который нужно отобразить
    public GameObject objectToDisplay;

    void Start()
    {
        // Запуск корутины для отображения объекта через заданное время
        StartCoroutine(DisplayObjectAfterDelay());
    }

    IEnumerator DisplayObjectAfterDelay()
    {
        // Ждем заданное время
        yield return new WaitForSeconds(delay);

        // Отображаем объект
        if (objectToDisplay != null)
        {
            objectToDisplay.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Object to display is not assigned.");
        }
    }
}
