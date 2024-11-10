using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectRevealer : MonoBehaviour
{
    // ������ �� ������
    public Button revealButton;

    // ������ �� ������, ������� ����� ����������
    public GameObject objectToReveal;

    void Start()
    {
        // ��������� ���������� ������� ������
        if (revealButton != null)
        {
            revealButton.onClick.AddListener(RevealObject);
        }
    }

    void RevealObject()
    {
        // ���������� ������
        if (objectToReveal != null)
        {
            objectToReveal.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Object to reveal is not assigned.");
        }
    }
}
