using UnityEngine;

public class RotatePropellor : MonoBehaviour
{
    float rotateSpeed = 150f;
    void Update()
    {
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }
}
