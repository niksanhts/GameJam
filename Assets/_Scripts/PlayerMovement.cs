
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(0, 1)] private float _speed;
    [SerializeField, Range(0, 1)] private float _rotationTime;


    private CharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    public void Move(Vector3 direction)
    {
        _controller.Move(direction * _speed);
        Rotate(direction);
    }

    public void Jump() 
    {

    }

    private void Rotate(Vector3 direction) 
    {
        if (direction != Vector3.zero)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), _rotationTime);
    }
}
