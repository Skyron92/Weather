using UnityEngine;

public class Camera : MonoBehaviour
{
    private float _x, _y;
    private float _rotationSpeed = 2f;
    private float _rotationMaxX = 45f;

    private void Update()
    {
        MouseMove();
    }

    void MouseMove()
    {
        _x += -Input.mousePosition.y * _rotationSpeed;
        _x = Mathf.Clamp(_x, -_rotationMaxX, _rotationMaxX);
        _y += -Input.mousePosition.x * _rotationSpeed;
        _y = Mathf.Clamp(_y, -80, 90);

        transform.localRotation *= Quaternion.Euler(_x, _y,0);
    }
}
