using UnityEngine;

[System.Serializable]
[UnityEngine.CreateAssetMenu(fileName = "SaveData", menuName = "Game/Save Data")]
public class SaveData : ScriptableObject
{
    public string Filename = "SaveData.json";
    public float MusicVolume;
    public float EffectsVolume;

    public int PlayerPrefab;
    public int WeaponPrefab;
}
