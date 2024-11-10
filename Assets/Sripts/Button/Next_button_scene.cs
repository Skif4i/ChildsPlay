using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class LoadSceneAfterButtonSequence : MonoBehaviour
{
    public Button[] buttons; // Массив кнопок, которые нужно нажать
    public string sceneName; // Имя сцены, которая должна быть загружена
    public float delay = 5f; // Задержка в секундах перед переходом на другую сцену

    private HashSet<Button> pressedButtons = new HashSet<Button>();

    private void Start()
    {
        if (buttons != null && buttons.Length > 0)
        {
            foreach (var button in buttons)
            {
                if (button != null)
                {
                    button.onClick.AddListener(() => OnButtonClick(button));
                }
            }
        }
    }

    private void OnButtonClick(Button button)
    {
        if (!pressedButtons.Contains(button))
        {
            pressedButtons.Add(button);
        }

        if (pressedButtons.Count >= buttons.Length)
        {
            Invoke("LoadScene", delay);
        }
    }

    private void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is not set in the inspector.");
        }
    }
}
