using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; // Speed of the vehicle
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
