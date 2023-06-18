using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 30;
    private float _distance = 0;
    private int _damage;

    void Update()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
        _distance += _speed * Time.deltaTime;

        if (_distance > 20) Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            other.GetComponent<Enemy>().TakeDamage(_damage);

        Destroy(gameObject);
    }

    public void Init(int damage) { _damage = damage; }
}
