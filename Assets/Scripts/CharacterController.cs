//Take input for player
//Aiming, Jumping, Shooting, Moving
//Just calls other methods

using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    InputAction attackAction;
    InputAction moveAimAction;


    InputAction jumpAction;


    public Spawner spawner;

    public CharacterMovement movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = GetComponent<CharacterMovement>();

        moveAimAction = InputSystem.actions.FindAction("Move");
        attackAction = InputSystem.actions.FindAction("Attack");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        spawner.isSpawning = attackAction.IsPressed();

        //Moveaction to aim

        Vector2 moveAimValue = moveAimAction.ReadValue<Vector2>();
        spawner.transform.right = moveAimValue;

        Debug.DrawRay(spawner.transform.position, moveAimValue);

        movement.moveInput = moveAimValue;

        if (jumpAction.WasPressedThisFrame())
        {
            movement.jumpRequested = true;
        }

    }
}
