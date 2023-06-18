using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "FloatEventChannel", menuName = "Game/Float Event Channel")]
public class FloatEventChannel : ScriptableObject
{
    public UnityAction<float> OnFloatEventRaised;

    public void RaiseFloatEvent(float arg0)
    {
        OnFloatEventRaised?.Invoke(arg0);
    }
}
