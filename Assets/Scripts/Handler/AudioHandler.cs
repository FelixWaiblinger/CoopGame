using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] private IntEventChannel _sceneEventChannel;
    [SerializeField] private AudioSource _music;
    [SerializeField] private List<AudioSource> _effects = new List<AudioSource>();
    [SerializeField] private AudioClip[] _songs = new AudioClip[]{};
    [SerializeField] private SaveData _saveData;

    #region SETUP

    void OnEnable()
    {
        _sceneEventChannel.OnIntEventRaised += ChangeMusic;
    }

    void OnDisable()
    {
        _sceneEventChannel.OnIntEventRaised -= ChangeMusic;
    }

    void Awake()
    {
        StartCoroutine(FadeAudio(0));
    }

    #endregion

    void Update()
    {
        // TODO this is done unnecessarily often -> use events
        ChangeVolume();
    }

    void ChangeVolume()
    {
        _music.volume = Mathf.MoveTowards(_music.volume, _saveData.MusicVolume, Time.deltaTime);

        foreach (var effect in _effects)
            effect.volume = Mathf.MoveTowards(_music.volume, _saveData.MusicVolume, Time.deltaTime);
    }

    void ChangeMusic(int index)
    {
        // return to title screen
        if (index == 0)
        {
            StartCoroutine(FadeAudio(0));
        }
        // start game
        else
        {
            int next = Random.Range(1, _songs.Length);
            StartCoroutine(FadeAudio(next));
        }
    }

    IEnumerator FadeAudio(int next)
    {
        // fade out
        for (int i = 0; i < 10; i++)
        {
            _music.volume -= 0.1f * _saveData.MusicVolume;
            yield return null;
        }

        _music.clip = _songs[next];
        _music.Play(); // necessary?

        // fade in
        for (int i = 0; i < 10; i++)
        {
            _music.volume += 0.1f * _saveData.MusicVolume;
            yield return null;
        }
    }
}
