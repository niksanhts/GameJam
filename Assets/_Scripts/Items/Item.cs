using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class Item : MonoBehaviour
{
       public void PickUp()
       {
              transform.rotation = Quaternion.identity;
       }
}
