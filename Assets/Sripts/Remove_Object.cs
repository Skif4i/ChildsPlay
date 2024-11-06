using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDeleter : MonoBehaviour
{
    // ������ �� ������
    public Button deleteButton;

    // ������ �� �������, ������� ����� �������
    public GameObject[] objectsToDelete;

    void Start()
    {
        // ��������� ���������� ������� ������
        if (deleteButton != null)
        {
            deleteButton.onClick.AddListener(DeleteObjects);
        }
    }

    void DeleteObjects()
    {
        // ������� ��� ��������� �������
        foreach (var obj in objectsToDelete)
        {
            if (obj != null)
            {
                Destroy(obj);
            }
        }
    }
}
