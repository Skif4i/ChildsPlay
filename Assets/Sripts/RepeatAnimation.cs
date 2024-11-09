using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatAnimation : MonoBehaviour
{
    public Animator animator; // Ссылка на компонент Animator
    public string animationTriggerName = "TriggerAnimation"; // Имя триггера для запуска анимации
    public float delayAfterAnimation = 5.0f; // Задержка после завершения анимации

    private float timer = 0.0f;
    private bool isAnimationPlaying = false;

    private void Update()
    {
        if (isAnimationPlaying)
        {
            // Проверяем, завершена ли анимация
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle") &&
                animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                isAnimationPlaying = false;
                timer = delayAfterAnimation;
            }
        }
        else
        {
            // Уменьшаем таймер
            timer -= Time.deltaTime;
            if (timer <= 0.0f)
            {
                // Запускаем анимацию
                animator.SetTrigger(animationTriggerName);
                isAnimationPlaying = true;
            }
        }
    }
}

