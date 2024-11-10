using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ButtonHandler : MonoBehaviour
{
    public Button[] buttons; // Массив кнопок
    public GameObject objectToHide; // Объект, который нужно скрыть
    public GameObject objectToReveal; // Объект, который нужно отобразить
    public AudioSource audioSource; // Источник звука
    public string nextSceneName; // Имя следующей сцены
    public bool enableSceneTransition = true; // Флаг для включения/выключения перехода на следующую сцену

    private HashSet<Button> pressedButtons = new HashSet<Button>();
    private int buttonsPressed = 0;

    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // Локальная переменная для захвата текущего индекса
            buttons[i].onClick.AddListener(() => OnButtonClick(buttons[index]));
        }

        if (objectToReveal != null)
        {
            objectToReveal.SetActive(false); // Убедимся, что скрытый объект изначально неактивен
        }
    }

    void OnButtonClick(Button button)
    {
        if (!pressedButtons.Contains(button))
        {
            pressedButtons.Add(button);
            buttonsPressed++;

            if (buttonsPressed == buttons.Length)
            {
                PlaySound();
                if (objectToHide != null)
                {
                    objectToHide.SetActive(false); // Скрываем объект
                }
                if (objectToReveal != null)
                {
                    objectToReveal.SetActive(true); // Отображаем скрытый объект
                }
                if (enableSceneTransition)
                {
                    Invoke("LoadNextScene", 4f); // Через 4 секунды вызовем метод LoadNextScene
                }
            }
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
