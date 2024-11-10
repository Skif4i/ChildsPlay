using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ButtonPressHandler : MonoBehaviour
{
    public GameObject objectToHide; // ������, ������� ����� ������
    public GameObject objectToShow; // ������, ������� ����� ����������
    public List<Button> buttons; // ������ ������, ������� ����� ������ �� �������

    private HashSet<Button> pressedButtons = new HashSet<Button>();
    private int uniqueButtonPresses = 0;
    private bool isWaiting = false;

    void Start()
    {
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => OnButtonClick(button));
        }
    }

    void OnButtonClick(Button button)
    {
        if (isWaiting)
            return;

        if (pressedButtons.Add(button))
        {
            uniqueButtonPresses++;
            if (uniqueButtonPresses >= 5)
            {
                isWaiting = true;
                Invoke("HideAndShowObjects", 2f);
            }
        }
    }

    void HideAndShowObjects()
    {
        objectToHide.SetActive(false);
        objectToShow.SetActive(true);
        isWaiting = false;
        pressedButtons.Clear();
        uniqueButtonPresses = 0;
    }
}

