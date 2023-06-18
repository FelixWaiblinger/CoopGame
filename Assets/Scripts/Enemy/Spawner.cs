using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _initialDelay;
    [SerializeField] private float _spawnDelay;
    private float _timer;

    void Start()
    {
        _timer = _initialDelay;
    }

    void FixedUpdate()
    {
        if (_timer > 0)
        {
            _timer -= Time.fixedDeltaTime;
            return;
        }
        else
        {
            Instantiate(_enemy, transform.position, transform.rotation);
            _timer = _spawnDelay;
        }
    }
}
