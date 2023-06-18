using UnityEngine;

public class GreenBeetle : Enemy
{
    void FixedUpdate()
    {
        SelectTarget();

        Move();

        Attack();
    }

    void Update()
    {
        DamageVisual();
    }

    #region UPDATES

    void SelectTarget()
    {
        if (_target) return;

        // select closest player as target
        float minDistance = float.MaxValue;
        foreach (var p in GameObject.FindGameObjectsWithTag("Player"))
        {
            var distance = Vector3.Distance(transform.position, p.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                _target = p.transform;
            }
        }
    }

    void Move()
    {
        if (!_target) return;

        if (_attacking) return;

        if (Vector3.Distance(transform.position, _target.position) > 1)
            _body.velocity = _speed * (_target.position - transform.position).normalized;
    }

    void Attack()
    {
        if (!_target) return;

        if (Vector3.Distance(transform.position, _target.position) <= 1)
        {
            _attacking = true;
            // TODO attack
        }
    }

    void DamageVisual()
    {
        if (_damageTimer > 0) _damageTimer -= Time.deltaTime;
        else _renderer.material = _defaultMaterial; // TODO probably not very efficient
    }

    #endregion

    public override void TakeDamage(int amount)
    {
        _renderer.material = _damageMaterial;
        _damageTimer = 0.1f;

        _currentHealth -= amount;
        Debug.Log($"{gameObject.name} took {amount} damage!");

        if (_currentHealth <= 0)
        {
            Debug.Log($"{gameObject.name} died!");
            Destroy(gameObject);
        }
    }
}
