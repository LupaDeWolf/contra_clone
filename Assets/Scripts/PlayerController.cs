using Microsoft.Extensions.DependencyInjection;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float jumpSpeed = 20f;

    InputAction moveAction;

    InputAction jumpAction;
    

    

    public bool isGrounded = false;
    public Rigidbody2D rb;

    public bool isMoving;

    private void Awake()
    { 
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");

        rb = GetComponent<Rigidbody2D>();
    }

    


    // Update is called once per frame
    void Update()
    {

        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        
        rb.linearVelocityX = (moveValue.x * moveSpeed);
        
        

        if (jumpAction.WasPressedThisFrame() && isGrounded)
        {
            rb.linearVelocityY = jumpSpeed;
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
