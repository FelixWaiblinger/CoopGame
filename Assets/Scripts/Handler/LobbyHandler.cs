using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class LobbyHandler : MonoBehaviour
{
    [Header("Events")]
    [SerializeField] private IntEventChannel _sceneEventChannel;
    [SerializeField] private IntEventChannel _joinEventChannel;
    [SerializeField] private VoidEventChannel _startEventChannel;
    [SerializeField] private VoidEventChannel _menuEventChannel;

    [Header("Visuals")]
    [SerializeField] private GameObject _menu;
    [SerializeField] private Image _fadeBlack;
    [SerializeField] private TMP_Text _startText;
    [SerializeField] private TMP_Text _menuText;
    [SerializeField] private GameObject[] _slots = new GameObject[]{};
    [SerializeField] private Transform[] _poses = new Transform[]{};
    private int _numPlayers = 0;

    #region SETUP

    void OnEnable()
    {
        _joinEventChannel.OnIntEventRaised += PlayerJoined;
        _startEventChannel.OnVoidEventRaised += StartPressed;
        _menuEventChannel.OnVoidEventRaised += () => _menu.SetActive(true);
    }

    void OnDisable()
    {
        _joinEventChannel.OnIntEventRaised -= PlayerJoined;
        _startEventChannel.OnVoidEventRaised -= StartPressed;
    }

    #endregion

    IEnumerator PlayCoroutine()
    {
        while (_fadeBlack.color.a < 1)
        {
            _fadeBlack.color += new Color(0, 0, 0, Time.deltaTime);
            yield return null;
        }

        yield return new WaitForSeconds(1);

        _sceneEventChannel.RaiseIntEvent(2);
    }

    #region EVENTS

    public void PlayerJoined(int index)
    {
        _startText.enabled = true;
        _menuText.enabled = true;
        
        _slots[_numPlayers].SetActive(false);

        foreach (var p in GameObject.FindObjectsOfType<PlayerInput>())
        {
            if (p.playerIndex != index) continue;
            
            p.transform.position = _poses[_numPlayers].position;
            p.transform.rotation = _poses[_numPlayers].rotation;
        }
        
        _numPlayers++;
    }

    void StartPressed()
    {
        if (_numPlayers == 0) return;
        
        StartCoroutine(PlayCoroutine());
    }

    #endregion
}
