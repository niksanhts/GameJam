using UnityEngine;

public class ModelRotator : MonoBehaviour
{
    public void Rotate(Vector3 direction, float rotationTime)
    {
        if (direction != Vector3.zero)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationTime);
    }
}
