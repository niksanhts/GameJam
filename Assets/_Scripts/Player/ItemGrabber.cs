using System;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class ItemGrabber : MonoBehaviour
{
    [SerializeField, Range(0, 5)] private float _pickUpRadius;
    [SerializeField, Range(1, 10)] private float _throwingForce;
    [SerializeField] private Transform _itemHolder;
    
    private Collider[] _itemsAround = new Collider[12];
    private Rigidbody _itemInHands;
    private bool _isItemInHands;

    private void Update()
    {
        if (_isItemInHands)
        {
            _itemInHands.transform.position = _itemHolder.position;
            _itemInHands.rotation = Quaternion.LookRotation(transform.forward);
        }
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

        _itemInHands.AddForce(transform.forward * _throwingForce, ForceMode.Impulse);
        _itemInHands = null;
        _isItemInHands = false;
    }
    
    private void PickUpItem(Component component)
    {

        component.GetComponent<Item>().PickUp();
        _itemInHands = component.gameObject.GetComponent<Rigidbody>();
        _isItemInHands = true;
    }
}

