using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationSpeedController : MonoBehaviour
{
    public Animator animator; // ������ �� ��������� Animator
    public Button speedUpButton; // ������ �� ������
    public float speedMultiplier = 2.0f; // ��������� �������� ��������

    private void Start()
    {
        if (speedUpButton != null)
        {
            speedUpButton.onClick.AddListener(SpeedUpAnimation);
        }
    }

    private void SpeedUpAnimation()
    {
        if (animator != null)
        {
            animator.speed *= speedMultiplier;
        }
    }
}
