using System;
using _Scripts;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class ItemGrabber : MonoBehaviour
{
    [SerializeField, Range(0, 5)] private float _pickUpRadius;
    [SerializeField, Range(1, 10)] private float _throwingForce;
    [SerializeField] private Transform _itemHolder;

    [SerializeField] private SoundPlayer _soundPlayer;
    
    private Collider[] _itemsAround = new Collider[12];
    private Rigidbody _itemInHands;
    private bool _isItemInHands;

    private void Update()
    {
        if (_isItemInHands)
            KeepItem();
    }
    
    public void FindItemsToPickUp()
    {
        
        _itemsAround = Physics.OverlapSphere(transform.position, _pickUpRadius);

        foreach (var item in _itemsAround) 
        { 
            if (item.GetComponent<Item>() != null) 
            {
                PickUpItem(item);
                return;
            }
        }
    }

    public void ThrowItem()
    {
        if (!_isItemInHands) return;

        _itemInHands.AddForce(transform.forward * _throwingForce, ForceMode.Force);
        _itemInHands = null;
        _isItemInHands = false;
        
        _soundPlayer.PlayThrowSound();
    }
    
    private void PickUpItem(Component component)
    {
        component.GetComponent<Item>().PickUp();
        _itemInHands = component.gameObject.GetComponent<Rigidbody>();
        _isItemInHands = true;
        
        _soundPlayer.PlayPickUpSound();
    }

    private void KeepItem()
    {
        _itemInHands.transform.position = _itemHolder.position;
        _itemInHands.rotation = Quaternion.LookRotation(transform.forward);
    }
}

