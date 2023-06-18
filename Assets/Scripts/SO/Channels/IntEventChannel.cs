using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "IntEventChannel", menuName = "Game/Int Event Channel")]
public class IntEventChannel : ScriptableObject
{
    public UnityAction<int> OnIntEventRaised;

    public void RaiseIntEvent(int arg0)
    {
        OnIntEventRaised?.Invoke(arg0);
    }
}
