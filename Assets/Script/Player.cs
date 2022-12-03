using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [Range(1, 100)] public float _speed;
    private CharacterController _controller;
    private float gravityValue = -9.81f;
    private Vector3 playerVelocity;


    private void Awake() {
        _controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(move * Time.deltaTime * _speed);
        playerVelocity.y += gravityValue * Time.deltaTime;
        _controller.Move(playerVelocity * Time.deltaTime);
    }

    
    
}