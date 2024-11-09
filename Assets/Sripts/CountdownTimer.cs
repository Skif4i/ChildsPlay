using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text countdownText; // ��������� ���� ��� ����������� ��������� ������
    public GameObject objectToShow; // ������, ������� ������ �������
    public GameObject objectToHide; // ������, ������� ������ �������
    public float countdownTime = 300.0f; // ����� ��������� ������ � �������� (5 �����)

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
