using _Scripts.Player;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerAnimator))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(1, 5)] private float _speed;
    [SerializeField, Range(0, 4)] private float _rotationTime;
    [SerializeField] private ModelRotator _rotator;
    
    private CharacterController _controller;
    private PlayerAnimator _animator;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponent<PlayerAnimator>();
    }

    public void Move(Vector3 direction)
    {
        if (direction != Vector3.zero)
            Walk(direction);
        else
            Stand();
    }

    private void Stand()
    {
        
    }

    private void Walk(Vector3 direction)
    {
        
        _controller.Move(direction * (Time.deltaTime * _speed));
        _rotator.Rotate(direction, _rotationTime);
    }
}
