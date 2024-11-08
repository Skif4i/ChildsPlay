using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObjectAfterDelay : MonoBehaviour
{
    public GameObject objectToShow; // Объект, который будет отображен
    public float delay = 5f; // Время задержки в секундах

    private void Start()
    {
        // Отключаем объект при старте
        if (objectToShow != null)
        {
            objectToShow.SetActive(false);
        }

        // Запускаем корутину для задержки
        StartCoroutine(ShowObjectAfterDelayCoroutine());
    }

    private IEnumerator ShowObjectAfterDelayCoroutine()
    {
        yield return new WaitForSeconds(delay);

        // Включаем объект после задержки
        if (objectToShow != null)
        {
            objectToShow.SetActive(true);
        }
    }
}
