using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [Range(1, 100)] public float _speed;
    private float _h, _v;
    private Rigidbody _rb;

    private void Awake()
    { _rb = GetComponent<Rigidbody>(); }


    void Update() {
        MoveRight();
        MoveForward();
    }


    void MoveRight()
    {
        _h += Input.GetAxisRaw("Horizontal");
        _rb.AddForce(Vector3.right * _h * Time.deltaTime, ForceMode.Impulse);
        _rb.velocity = Vector3.zero;
    }
    
    void MoveForward()
    {
        _v += Input.GetAxisRaw("Vertical");
        _rb.AddForce(Vector3.forward * _v *Time.deltaTime, ForceMode.Impulse);
        _rb.velocity = Vector3.zero;
    }
}