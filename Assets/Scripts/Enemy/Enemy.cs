using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected Rigidbody _body;
    [SerializeField] protected float _speed;
    [SerializeField] protected int _maxHealth;
    protected int _currentHealth;
    protected Transform _target;
    protected bool _attacking = false;
    [SerializeField] protected Renderer _renderer;
    [SerializeField] protected Material _damageMaterial;
    protected Material _defaultMaterial;
    protected float _damageTimer = 0;

    void Awake()
    {
        _currentHealth = _maxHealth;
        _defaultMaterial = _renderer.material;
    }

    public abstract void TakeDamage(int _);
}
