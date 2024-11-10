using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleVisibility : MonoBehaviour
{
    public GameObject[] objectsToToggle; // ������ �������� ��� ������������ ���������
    public Button toggleButton; // ������ ��� ������������ ���������

    private bool isVisible = false;

    void Start()
    {
        if (toggleButton != null)
        {
            toggleButton.onClick.AddListener(ToggleObjectsVisibility);
        }
    }

    void ToggleObjectsVisibility()
    {
        isVisible = !isVisible;
        foreach (var obj in objectsToToggle)
        {
            if (obj != null)
            {
                obj.SetActive(isVisible);
            }
        }
    }
}
