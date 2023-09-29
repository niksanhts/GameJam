using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;


[RequireComponent(typeof(PlayerMovement))]
public class InputHandler : MonoBehaviour
{
    
    private PlayerInput _input;
    private PlayerMovement _movement;
    private ItemGrabber _grabber;

    private void Awake()
    {
        _input = new PlayerInput();
        _movement = GetComponent<PlayerMovement>();
        _grabber = GetComponent<ItemGrabber>();
    }

    private void OnEnable() => _input.Enable();

    private void OnDisable() => _input.Disable();

    private void Update()
    {
        _movement.Move(CalculateDirecrion());
        
        if (_input.Player.Grab.phase == InputActionPhase.Performed)
            _grabber.FindItemsToPickUp();
        
        if(_input.Player.Throw.phase == InputActionPhase.Performed)
            _grabber.ThrowItem();
    }

    private Vector3 CalculateDirecrion() 
    {
        Vector2 input = _input.Player.Move.ReadValue<Vector2>();
        
        return transform.forward * input.y + transform.right * input.x;
    }

}
