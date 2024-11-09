using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationSpeedController : MonoBehaviour
{
    public Animator animator; // —сылка на компонент Animator
    public Button speedUpButton; // —сылка на кнопку
    public float speedMultiplier = 2.0f; // ћножитель скорости анимации

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
