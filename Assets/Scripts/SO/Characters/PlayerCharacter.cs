using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Game/Character")]
public class PlayerCharacter : ScriptableObject
{
    public GameObject CharacterModel;
    public float MoveSpeed;
    public float RollCD;
    public int MaxHealth;

    public Dictionary<string, float> Multiplier = new Dictionary<string, float>()
    {
        {"AllDmg", 1},
        {"WeaponDmg", 1},
        {"MainDmg", 1},
        {"MainMag", 1},
        {"OffDmg", 1},
        {"OffMag", 1},
        {"RoF", 1},
        {"SkillDmg", 1},
        {"SkillCD", 1},
        {"PrimaryDmg", 1},
        {"SecondaryDmg", 1},
        {"UltimateDmg", 1},
    };
}
