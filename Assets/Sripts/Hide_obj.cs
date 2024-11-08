using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObjectAfterDelay : MonoBehaviour
{
    public GameObject objectToShow; // ������, ������� ����� ���������
    public float delay = 5f; // ����� �������� � ��������

    private void Start()
    {
        // ��������� ������ ��� ������
        if (objectToShow != null)
        {
            objectToShow.SetActive(false);
        }

        // ��������� �������� ��� ��������
        StartCoroutine(ShowObjectAfterDelayCoroutine());
    }

    private IEnumerator ShowObjectAfterDelayCoroutine()
    {
        yield return new WaitForSeconds(delay);

        // �������� ������ ����� ��������
        if (objectToShow != null)
        {
            objectToShow.SetActive(true);
        }
    }
}
