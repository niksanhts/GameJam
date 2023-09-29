using System;
using _Scripts;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Player : MonoBehaviour, IMoveable
{
    private CharacterController _controller;
    private PlayerInput _input;
    
    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _input = new PlayerInput();
    }

    private void OnEnable() => _input.Enable();

    private void OnDisable() => _input.Disable();
    
    public void Move(Vector3 direction)
    {
        
    }
}

