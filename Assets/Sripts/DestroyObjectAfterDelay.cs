using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObjectAfterDelay : MonoBehaviour
{
    public Button destroyButton; // ������ �� ������
    public GameObject objectToDestroy; // ������, ������� ����� ���������
    public float delayBeforeDestroy = 5.0f; // �������� ����� ������������ �������

    private void Start()
    {
        if (destroyButton != null)
        {
            destroyButton.onClick.AddListener(ScheduleDestroy);
        }
    }

    private void ScheduleDestroy()
    {
        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy, delayBeforeDestroy);
        }
    }
}
