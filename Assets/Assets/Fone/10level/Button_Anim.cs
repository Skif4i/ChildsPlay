using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    public Animator animator; // Ссылка на компонент Animator
    public Button playButton; // Ссылка на кнопку

    void Start()
    {
        // Добавляем обработчик события нажатия кнопки
        playButton.onClick.AddListener(PlayAnimation);
    }

    void PlayAnimation()
    {
        // Включаем анимацию
        animator.SetTrigger("PlayAnimation");
    }
}
