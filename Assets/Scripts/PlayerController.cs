using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float jumpSpeed = 20f;
    InputAction moveAction;
    InputAction jumpAction;

    public Vector2 moveValue;

    public bool jumpPressedThisFrame;

    public bool isGrounded = false;
    private Rigidbody2D rigidBody;

    private void Awake()
    { 
        
    }

    


    // Update is called once per frame
    void Update()
    {

        
        

        if (jumpPressedThisFrame && isGrounded)
        {
            rigidBody.linearVelocityY = jumpSpeed;
  
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)    
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
