using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading.Tasks;

public class levelTrasition : MonoBehaviour
{
    public int sceneNumber;
    public int delay = 0;
    public bool clicked = false;
    public AudioClip audioClip;
    public GameObject[] objectsToDelete;

    public async void Transinion()
    {
        if (clicked)
        {
            return;
        }

        // вызов звука

        clicked = true;

        if (audioClip)
        {
            AudioSource audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = audioClip;
            audioSource.Play();
        }
        DeleteObjects();

        await DelayAsync(delay, sceneNumber);
    }

    static async Task DelayAsync(int milliseconds, int sceneN)
    {
        await Task.Delay(milliseconds);
        SceneManager.LoadScene(sceneN);
    }
    void DeleteObjects()
    {
        // Удаляем все объекты из массива
        foreach (var obj in objectsToDelete)
        {
            Destroy(obj);
        }
    }

}
