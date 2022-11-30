using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float _x, _z, _speed;
    private Transform _transform;

    private void Awake()
    { _transform = GetComponent<Transform>(); }

   
    void Update()
    { Move(); }


    void Move()
    { _x += Input.GetAxisRaw("Horizontal");
        _z += Input.GetAxisRaw("Vertical");
        Vector3 position = _transform.position;
        position = new Vector3(_x, _transform.position.y, _z) * _speed * Time.deltaTime;
        _transform.position = position; }
}
