using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _cameraPosition;
    [SerializeField] private float _defaultHeight;
    private Transform _p1;
    private Transform _p2;
    
    void Start()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");
        _p1 = players[0].transform;
        _p2 = players.Length > 0 ? players[1].transform : null;
    }

    void Update()
    {
        // multiplayer
        if (_p2)
        {
            var direction = _p2.position - _p1.position;
            transform.position = _p1.position + direction * 0.5f;

            var height = _defaultHeight + 0.1f * Vector3.Distance(_p2.position, _p1.position);
            _cameraPosition.position = Vector3.up * height;
        }
        // singleplayer
        else
        {
            transform.position = _p1.position;
            _cameraPosition.position = Vector3.up * _defaultHeight;
        }
    }
}
