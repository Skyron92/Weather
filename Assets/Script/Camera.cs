using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float _x;

    private void Update()
    {
        MouseMove();
    }

    void MouseMove()
    {
        _x += Input.mousePosition.x;
        transform.rotation = new Quaternion(0, _x, 0, 0);
    }
}
