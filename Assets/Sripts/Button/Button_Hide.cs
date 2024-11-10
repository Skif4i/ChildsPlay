using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideButtonAfterDelay : MonoBehaviour
{
    public Button buttonToHide; // Кнопка, которая будет скрыта
    public float delay = 5f; // Задержка в секундах

    private void Start()
    {
        if (buttonToHide != null)
        {
            buttonToHide.onClick.AddListener(OnButtonClick);
        }
    }

    private void OnButtonClick()
    {
        Invoke("HideButton", delay);
    }

    private void HideButton()
    {
        if (buttonToHide != null)
        {
            buttonToHide.gameObject.SetActive(false);
        }
    }
}
