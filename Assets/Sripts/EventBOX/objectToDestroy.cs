using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectAfterDelayScript : MonoBehaviour
{
    public GameObject objectToDestroy; // ������, ������� ����� ���������
    public float delay = 5f; // �������� � ��������

    private void Start()
    {
        if (objectToDestroy != null)
        {
            Invoke("DestroyObject", delay);
        }
    }

    private void DestroyObject()
    {
        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }
    }
}
