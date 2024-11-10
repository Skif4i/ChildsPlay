using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatAnimation : MonoBehaviour
{
    public Animator animator; // ������ �� ��������� Animator
    public string animationTriggerName = "TriggerAnimation"; // ��� �������� ��� ������� ��������
    public float delayAfterAnimation = 5.0f; // �������� ����� ���������� ��������

    private float timer = 0.0f;
    private bool isAnimationPlaying = false;

    private void Update()
    {
        if (isAnimationPlaying)
        {
            // ���������, ��������� �� ��������
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle") &&
                animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                isAnimationPlaying = false;
                timer = delayAfterAnimation;
            }
        }
        else
        {
            // ��������� ������
            timer -= Time.deltaTime;
            if (timer <= 0.0f)
            {
                // ��������� ��������
                animator.SetTrigger(animationTriggerName);
                isAnimationPlaying = true;
            }
        }
    }
}

