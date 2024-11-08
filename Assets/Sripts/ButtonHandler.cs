using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public Button[] buttons; // Массив кнопок
    public GameObject[] hiddenObjects; // Массив скрытых объектов
    public AudioSource audioSource; // Источник звука
    public string nextSceneName; // Имя следующей сцены

    private int buttonsPressed = 0;

    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // Локальная переменная для захвата текущего индекса
            buttons[i].onClick.AddListener(() => OnButtonClick(index));
        }

        foreach (var obj in hiddenObjects)
        {
            obj.SetActive(false); // Убедимся, что все скрытые объекты изначально неактивны
        }
    }

    void OnButtonClick(int index)
    {
        if (index < hiddenObjects.Length)
        {
            hiddenObjects[index].SetActive(true); // Отображаем скрытый объект
        }

        buttonsPressed++;

        if (buttonsPressed == buttons.Length)
        {
            PlaySound();
            Invoke("LoadNextScene", 4f); // Через 4 секунды вызовем метод LoadNextScene
        }
    }

    void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play(); // Проигрываем звук
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName); // Переход на следующую сцену
    }
}
