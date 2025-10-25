using UnityEngine;

public class MouseInteract : MonoBehaviour
{
    [SerializeField]
    Camera mainCamera;

    void Update()
    {       
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        transform.position = mousePos;
    }
}
