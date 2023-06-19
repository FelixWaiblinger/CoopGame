using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private float _defaultHeight;
    [SerializeField] private float _defaultOffset;
    private Transform _p1;
    private Transform _p2;
    
    void Start()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");
        _p1 = players[0].transform;
        _p2 = players.Length > 1 ? players[1].transform : null;
    }

    void Update()
    {
        var height = Vector3.up * (
            _p2 ? _defaultHeight + 0.2f * Vector3.Distance(_p2.position, _p1.position)
                : _defaultHeight
        );
        var pos = (
            _p2 ? (_p1.position + _p2.position) * 0.5f
                : _p1.position
        );
        var offset = Vector3.forward * (
            _p2 ? _defaultOffset - 0.4f * Vector3.Distance(_p2.position, _p1.position)
                : _defaultOffset
        );
        
        transform.position = pos + offset + height;
    }
}
