using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHandler : MonoBehaviour
{
    [SerializeField] private IntEventChannel _joinEventChannel;
    [SerializeField] private PlayerCharacter[] _characters = new PlayerCharacter[]{};

    public void PlayerJoined(PlayerInput inputs)
    {
        // move player to init scene
        inputs.transform.SetParent(transform);

        var index = inputs.playerIndex;
        Debug.Log($"Player {index} joined");

        inputs.GetComponent<PlayerController>().SetCharacter(_characters[index]);

        _joinEventChannel.RaiseIntEvent(index);
    }
}
