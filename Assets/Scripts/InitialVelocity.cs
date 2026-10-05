using UnityEngine;

public class InitialVelocity : MonoBehaviour
{

    public Vector2 velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = velocity;
        
    }

    
}
