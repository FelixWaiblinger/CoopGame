using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private bool _main;
    private Dictionary<string, float> _multiplier;

    [Header("WeaponStats")]
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Transform _bulletSpawn;
    private Quaternion _shootDirection;

    [SerializeField] private int _baseDamage = 1;
    private float _damageMultiplier;

    [SerializeField] private int _baseMagazine = 10;
    private int _currentMagazine;
    private float _magazineMultiplier;

    [SerializeField] private float _baseRateOfFire = 1; // per second
    private float _rateOfFireMultiplier;
    private float _lastShot = 0;
    
    #region SETUP

    void OnEnable()
    {
        // TODO update stats on upgrade
    }

    void OnDisable()
    {
        // TODO update stats on upgrade
    }

    void Start()
    {
        _currentMagazine = _baseMagazine;
        UpdateStats();
    }

    public void SetMultiplier(Dictionary<string, float> multiplier)
    {
        _multiplier = multiplier;
    }

    #endregion

    void UpdateStats()
    {
        _damageMultiplier =
            _multiplier["AllDmg"] *
            _multiplier["WeaponDmg"] *
            _multiplier[_main ? "MainDmg" : "OffDmg"];

        _magazineMultiplier =
            _multiplier[_main ? "MainMag" : "OffMag"];

        _rateOfFireMultiplier =
            _multiplier["RoF"];
    }

    public void Shoot(Quaternion direction)
    {
        Debug.Log($"Current Mag: {_currentMagazine}");

        // reload
        if (_currentMagazine == 0) return; // causes an issue?

        // cannot shoot faster than RoF
        if (Time.time < (_lastShot + (1 / _baseRateOfFire))) return;

        _lastShot = Time.time;

        var bullet = Instantiate(_bullet, _bulletSpawn.position, direction);
        bullet.Init((int)(_baseDamage * _damageMultiplier));
    }
}
