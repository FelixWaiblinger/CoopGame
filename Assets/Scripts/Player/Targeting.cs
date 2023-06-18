using UnityEngine;

public class Targeting : MonoBehaviour
{
    public void SetTargetDirection(Vector3 direction)
    {
        transform.position = transform.parent.position + Vector3.up + direction.normalized * 5;
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
