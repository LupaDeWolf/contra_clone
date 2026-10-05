using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float jumpSpeed = 20f;
    InputAction moveAction;
    InputAction jumpAction;

    public bool isGrounded = false;
    private Rigidbody2D rigidBody;

    private void Awake()
    { 
        rigidBody = GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    


    // Update is called once per frame
    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        rigidBody.linearVelocityX = moveValue.x * moveSpeed;

        if (jumpAction.WasPressedThisFrame() && isGrounded)
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
