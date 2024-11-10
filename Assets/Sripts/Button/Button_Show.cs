using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHiddenObject : MonoBehaviour
{
    public Button showButton; // Кнопка для нажатия
    public GameObject hiddenObject; // Скрытый объект
    public float delay = 5f; // Задержка в секундах

    private void Start()
    {
        if (showButton != null)
        {
            showButton.onClick.AddListener(OnButtonClick);
        }
    }

    private void OnButtonClick()
    {
        Invoke("ShowObject", delay);
    }

    private void ShowObject()
    {
        if (hiddenObject != null)
        {
            hiddenObject.SetActive(true);
        }
    }
}
