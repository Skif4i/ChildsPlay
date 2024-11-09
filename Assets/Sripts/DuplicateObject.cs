using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateObject : MonoBehaviour
{
    public GameObject objectToDuplicate; // Объект, который будет дублироваться
    public float duplicateInterval = 15.0f; // Интервал дублирования объекта

    private float timer = 0.0f;

    private void Update()
    {
        // Уменьшаем таймер
        timer -= Time.deltaTime;
        if (timer <= 0.0f)
        {
            // Дублируем объект
            Instantiate(objectToDuplicate, objectToDuplicate.transform.position, objectToDuplicate.transform.rotation);
            timer = duplicateInterval;
        }
    }

    private void OnEnable()
    {
        // Устанавливаем начальное значение таймера
        timer = duplicateInterval;
    }
}
