using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDisplay : MonoBehaviour
{
    // ����� �������� ����� ������������ �������
    public float delay = 5f;

    // ������ �� ������, ������� ����� ����������
    public GameObject objectToDisplay;

    void Start()
    {
        // ������ �������� ��� ����������� ������� ����� �������� �����
        StartCoroutine(DisplayObjectAfterDelay());
    }

    IEnumerator DisplayObjectAfterDelay()
    {
        // ���� �������� �����
        yield return new WaitForSeconds(delay);

        // ���������� ������
        if (objectToDisplay != null)
        {
            objectToDisplay.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Object to display is not assigned.");
        }
    }
}
