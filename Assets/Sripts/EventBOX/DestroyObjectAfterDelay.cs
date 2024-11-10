using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObjectAfterDelay : MonoBehaviour
{
    public Button destroyButton; // Ссылка на кнопку
    public GameObject objectToDestroy; // Объект, который будет уничтожен
    public float delayBeforeDestroy = 5.0f; // Задержка перед уничтожением объекта

    private void Start()
    {
        if (destroyButton != null)
        {
            destroyButton.onClick.AddListener(ScheduleDestroy);
        }
    }

    private void ScheduleDestroy()
    {
        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy, delayBeforeDestroy);
        }
    }
}
