using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypewriterEffect : MonoBehaviour
{
    // ���� ��� ������ ���������� ���������� � ����������
    public Text textComponent;

    // ���� ��� ����� ������, ������� ����� ���������
    public string textToType;

    // �������� ������ � �������� � �������
    public float typingSpeed = 0.05f;

    // ��������� �������� ����� ���������
    private float timeSinceLastChar = 0f;

    void Start()
    {
        if (!string.IsNullOrEmpty(textToType))
        {
            StartTyping();
        }
    }

    void StartTyping()
    {
        textComponent.text = "";
        char currentChar = textToType[0];
        StartCoroutine(TypeChar(currentChar));
    }

    IEnumerator TypeChar(char currentChar)
    {
        while (textComponent.text.Length < textToType.Length)
        {
            timeSinceLastChar += Time.deltaTime;
            if (timeSinceLastChar >= 1 / typingSpeed)
            {
                timeSinceLastChar = 0f;
                textComponent.text += currentChar;
                int nextCharIndex = textComponent.text.Length;
                if (nextCharIndex < textToType.Length)
                {
                    currentChar = textToType[nextCharIndex];
                }
                yield return null;
            }
        }
    }
}
