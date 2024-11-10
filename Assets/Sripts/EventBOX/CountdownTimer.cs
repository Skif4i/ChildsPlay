using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text countdownText; // Текстовое поле для отображения обратного отчета
    public GameObject objectToShow; // Объект, который станет видимым
    public GameObject objectToHide; // Объект, который станет скрытым
    public float countdownTime = 300.0f; // Время обратного отчета в секундах (5 минут)

    private float currentTime;

    private void Start()
    {
        currentTime = countdownTime;
        UpdateCountdownText();
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;
        UpdateCountdownText();

        if (currentTime <= 0)
        {
            currentTime = 0;
            ShowHiddenObject();
            HideVisibleObject();
        }
    }

    private void UpdateCountdownText()
    {
        if (countdownText != null)
        {
            int minutes = Mathf.FloorToInt(currentTime / 60);
            int seconds = Mathf.FloorToInt(currentTime % 60);
            countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    private void ShowHiddenObject()
    {
        if (objectToShow != null)
        {
            objectToShow.SetActive(true);
        }
    }

    private void HideVisibleObject()
    {
        if (objectToHide != null)
        {
            objectToHide.SetActive(false);
        }
    }
}
