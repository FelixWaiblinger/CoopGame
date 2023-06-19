using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [Header("Events")]
    [SerializeField] private VoidEventChannel _interactChannel;
    [SerializeField] private VoidEventChannel _startEventChannel;
    [SerializeField] private VoidEventChannel _menuEventChannel;
    [SerializeField] private VoidEventChannel _deathEventChannel;

    [Header("Player")]
    [SerializeField] private PlayerInput _inputs;
    [SerializeField] private TMP_Text _identifier;
    private PlayerCharacter _character;
    private Animator _anim;

    // movement
    [SerializeField] private Rigidbody _body;
    private float _moveSpeed;
    private float _currentSpeed;
    private Vector3 _moveDirection = Vector3.zero;

    // rolling
    private float _rollSpeed = 30;
    private float _rollTimer = 0;
    private bool _rolling = false;
    private float _rollCD;

    // looking
    [SerializeField] private Targeting _targeting;
    private Vector3 _lookDirection = Vector3.zero;

    // status
    [SerializeField] private StatusCanvas _status;
    private int _maxHealth;
    private int _currentHealth;

    // weapons
    private Weapon _mainWeapon;
    private Weapon _offWeapon;

    // skills
    private Skill _primary;
    private Skill _secondary;
    private Skill _ultimate;

    #region SETUP

    void Start()
    {
        Instantiate(_character.CharacterModel, transform);
        _anim = gameObject.GetComponentInChildren<Animator>();
        _identifier.text = $"P{_inputs.playerIndex + 1}";

    	SetStats();

        SetWeapons();

        SetSkills();
    }

    void SetStats()
    {
        _maxHealth = _character.MaxHealth;
        _moveSpeed = _character.MoveSpeed;
        _rollCD = _character.RollCD;

        _currentHealth = _maxHealth;
        _currentSpeed = _moveSpeed;
    }

    void SetWeapons()
    {
        var weapons = gameObject.GetComponentsInChildren<Weapon>();
        _mainWeapon = weapons[0];
        _mainWeapon.SetMultiplier(_character.Multiplier);
    }

    void SetSkills()
    {
        var skills = gameObject.GetComponentsInChildren<Skill>();
        _primary = skills[0];
        _secondary = skills[1];
        _ultimate = skills[2];
    }

    public void SetCharacter(PlayerCharacter character)
    {
        _character = character;
    }

    #endregion

    #region UPDATES

    void Update()
    {
        Move();

        Rotate();

        RollTiming();

        SetAnimator();
    }

    void Move()
    {
        _body.velocity = _moveDirection * _currentSpeed;
    }

    void Rotate()
    {
        var targetRotation = _lookDirection != Vector3.zero ?
            Quaternion.LookRotation(_lookDirection, Vector3.up) :
            Quaternion.identity;

        if (transform.rotation == targetRotation) return;

        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            targetRotation,
            600 * Time.deltaTime
        );
    }

    void RollTiming()
    {
        if (_rollTimer > 0) _rollTimer -= Time.deltaTime; // rolling

        if (_rollTimer <= 0 && _rolling) // stop rolling, start cooldown
        {
            _rolling = false;
            _rollTimer = 3;
            _currentSpeed = _moveSpeed;
        }
    }

    void SetAnimator()
    {
        if (_moveDirection == Vector3.zero)
        {
            _anim.SetBool("Idle", true);
            _anim.SetBool("Dash", false);
            _anim.SetBool("Move", false);
        }
        else
        {
            if (_rolling)
            {
                _anim.SetBool("Dash", true);
                _anim.SetBool("Move", false);
            }
            else
            {
                _anim.SetBool("Move", true);
                _anim.SetBool("Dash", false);
            }
            _anim.SetBool("Idle", false);
            _anim.SetFloat("X", _moveDirection.x);
            _anim.SetFloat("Y", _moveDirection.z);
        }

    }

    #endregion

    #region INPUT

    public void OnMove(InputAction.CallbackContext ctx)
    {
        if (_rolling) return;

        var input = ctx.ReadValue<Vector2>();
        _moveDirection = new(input.x, 0, input.y);
    }

    public void OnLook(InputAction.CallbackContext ctx)
    {
        var input = ctx.ReadValue<Vector2>();

        if (input == Vector2.zero) return;

        _lookDirection = new Vector3(input.x, 0, input.y);

        _targeting.SetTargetDirection(_lookDirection);
    }

    public void OnMainhand(InputAction.CallbackContext ctx)
    {
        if (ctx.phase != InputActionPhase.Performed) return;
        
        _mainWeapon?.Shoot(transform.rotation);
        _anim.SetBool("Fire", true);
    }

    public void OnOffhand(InputAction.CallbackContext ctx)
    {
        if (ctx.phase != InputActionPhase.Performed) return;

        _offWeapon?.Shoot(transform.rotation);
        _anim.SetBool("Fire", true);
    }

    public void OnPrimary(InputAction.CallbackContext ctx)
    {
        if (ctx.phase != InputActionPhase.Performed) return;
        
        _primary?.Activate();
    }

    public void OnSecondary(InputAction.CallbackContext ctx)
    {
        if (ctx.phase != InputActionPhase.Performed) return;
        
        _secondary?.Activate();
    }

    public void OnUltimate(InputAction.CallbackContext ctx)
    {
        if (ctx.phase != InputActionPhase.Performed) return;
        
        _ultimate?.Activate();
    }

    public void OnRoll(InputAction.CallbackContext ctx)
    {
        if (ctx.phase != InputActionPhase.Performed) return;
        
        if (_rollTimer > 0) return;

        _rolling = true;
        _rollTimer = 0.25f;
        _currentSpeed = _rollSpeed;
    }

    public void OnInteract(InputAction.CallbackContext ctx)
    {
        if (ctx.phase != InputActionPhase.Performed) return;
        
        _interactChannel.RaiseVoidEvent();
    }

    public void OnContinue(InputAction.CallbackContext ctx)
    {
        if (ctx.phase != InputActionPhase.Performed) return;

        _startEventChannel.RaiseVoidEvent();
    }

    public void OnMenu(InputAction.CallbackContext ctx)
    {
        if (ctx.phase != InputActionPhase.Performed) return;
        
        _menuEventChannel.RaiseVoidEvent();
    }

    #endregion

    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;
        _status.UpdateHealth(_currentHealth, _maxHealth);
        _anim.SetTrigger("Hit");

        if (_currentHealth <= 0)
        {
            _anim.SetBool("Lose", true);
            _deathEventChannel.RaiseVoidEvent();
        }
    }
}
