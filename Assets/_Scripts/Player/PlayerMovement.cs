using UnityEngine;


[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(0, 1)] private float _speed;
    [SerializeField, Range(0, 1)] private float _rotationTime;
    [SerializeField] private ModelRotator _rotator;
    
    private CharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    public void Move(Vector3 direction)
    {
        _controller.Move(direction * _speed);
        _rotator.Rotate(direction, _rotationTime);
    }
}
