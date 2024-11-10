using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHiddenObject : MonoBehaviour
{
    public Button showButton; // ������ ��� �������
    public GameObject hiddenObject; // ������� ������
    public float delay = 5f; // �������� � ��������

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
