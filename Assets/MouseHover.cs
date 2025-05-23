using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLightFollow : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector2 mousePos = Mouse.current.position.ReadValue();
        Vector3 worldPos = cam.ScreenToWorldPoint(mousePos);
        worldPos.z = 0f; 
        transform.position = worldPos;
    }
}
