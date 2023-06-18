using UnityEngine;

public class CanvasOrientation : MonoBehaviour
{
    private Transform _camera;

    void Start()
    {
        FindCamera();
    }

    void Update()
    {
        if (!_camera) FindCamera();
        
        transform.rotation = _camera.rotation;
    }

    void FindCamera()
    {
        _camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
}
