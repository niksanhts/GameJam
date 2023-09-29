using UnityEngine;


[RequireComponent(typeof(PlayerMovement))]
public class InputHandler : MonoBehaviour
{
    private PlayerInput _input;
    private PlayerMovement _movement;

    private void Awake() 
    {
        _input = new PlayerInput();
        _movement = GetComponent<PlayerMovement>();
    }

    private void OnEnable() => _input.Enable();

    private void OnDisable() => _input.Disable();

    private void Update()
    {
        _movement.Move(_input.Player.Move.ReadValue<Vector3>());
    }

}
