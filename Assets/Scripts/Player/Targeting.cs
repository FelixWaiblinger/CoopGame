using UnityEngine;

public class Targeting : MonoBehaviour
{
    private Vector3 _targetPosition = Vector3.forward * 5;
    private Quaternion _targetRotation = Quaternion.identity;
    private Vector3 _start;

    void Update()
    {
        var player = transform.parent.position + Vector3.up;
        transform.position = Vector3.MoveTowards(transform.position, player + _targetPosition, 1);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _targetRotation, 1);
    }

    public void SetTargetDirection(Vector3 direction)
    {
        _targetPosition = direction.normalized * 5;
        _targetRotation = Quaternion.LookRotation(direction);
    }
}
