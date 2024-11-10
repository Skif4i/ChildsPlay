using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDeleter : MonoBehaviour
{
    // Ссылка на кнопку
    public Button deleteButton;

    // Ссылки на объекты, которые нужно удалить
    public GameObject[] objectsToDelete;

    void Start()
    {
        // Добавляем обработчик нажатия кнопки
        if (deleteButton != null)
        {
            deleteButton.onClick.AddListener(DeleteObjects);
        }
    }

    void DeleteObjects()
    {
        // Удаляем все выбранные объекты
        foreach (var obj in objectsToDelete)
        {
            if (obj != null)
            {
                Destroy(obj);
            }
        }
    }
}
