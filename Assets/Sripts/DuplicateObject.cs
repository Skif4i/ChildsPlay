using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateObject : MonoBehaviour
{
    public GameObject objectToDuplicate; // ������, ������� ����� �������������
    public float duplicateInterval = 15.0f; // �������� ������������ �������

    private float timer = 0.0f;

    private void Update()
    {
        // ��������� ������
        timer -= Time.deltaTime;
        if (timer <= 0.0f)
        {
            // ��������� ������
            Instantiate(objectToDuplicate, objectToDuplicate.transform.position, objectToDuplicate.transform.rotation);
            timer = duplicateInterval;
        }
    }

    private void OnEnable()
    {
        // ������������� ��������� �������� �������
        timer = duplicateInterval;
    }
}
