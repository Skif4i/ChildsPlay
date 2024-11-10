using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    public Animator animator; // ������ �� ��������� Animator
    public Button playButton; // ������ �� ������

    void Start()
    {
        // ��������� ���������� ������� ������� ������
        playButton.onClick.AddListener(PlayAnimation);
    }

    void PlayAnimation()
    {
        // �������� ��������
        animator.SetTrigger("PlayAnimation");
    }
}
