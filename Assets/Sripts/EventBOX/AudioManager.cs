using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public List<AudioClip> audioClips;
    public Slider volumeSlider;
    private AudioSource audioSource;
    private int currentClipIndex = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        if (volumeSlider != null)
        {
            volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
            volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1.0f);
        }

        PlayAudioClip(currentClipIndex);
    }

    private void OnVolumeChanged(float value)
    {
        audioSource.volume = value;
        PlayerPrefs.SetFloat("Volume", value);
    }

    public void PlayAudioClip(int index)
    {
        if (index >= 0 && index < audioClips.Count)
        {
            audioSource.clip = audioClips[index];
            audioSource.Play();
            currentClipIndex = index;
        }
    }

    public void NextAudioClip()
    {
        currentClipIndex = (currentClipIndex + 1) % audioClips.Count;
        PlayAudioClip(currentClipIndex);
    }

    public void PreviousAudioClip()
    {
        currentClipIndex = (currentClipIndex - 1 + audioClips.Count) % audioClips.Count;
        PlayAudioClip(currentClipIndex);
    }
}
