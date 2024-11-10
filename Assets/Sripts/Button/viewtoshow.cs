using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectRevealer : MonoBehaviour
{
    // Ссылка на кнопку
    public Button revealButton;

    // Ссылка на объект, который нужно отобразить
    public GameObject objectToReveal;

    void Start()
    {
        // Добавляем обработчик нажатия кнопки
        if (revealButton != null)
        {
            revealButton.onClick.AddListener(RevealObject);
        }
    }

    void RevealObject()
    {
        // Отображаем объект
        if (objectToReveal != null)
        {
            objectToReveal.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Object to reveal is not assigned.");
        }
    }
}
