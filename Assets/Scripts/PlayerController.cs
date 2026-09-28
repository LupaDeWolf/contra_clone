using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float jumpSpeed = 20f;
    InputAction moveAction;
    InputAction jumpAction;
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

        if (jumpAction.WasPressedThisFrame())
        {
            rigidBody.linearVelocityY = jumpSpeed;
        }
    }
}
