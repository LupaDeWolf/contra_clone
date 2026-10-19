//Take input for player
//Aiming, Jumping, Shooting, Moving
//Just calls other methods

using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    InputAction attackAction;
    InputAction moveAction;
    InputAction jumpAction;
    

    public Spawner spawner;

    public PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        attackAction = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        spawner.isSpawning = attackAction.IsPressed();

        //Moveaction to aim

        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        spawner.transform.right = moveValue;
        playerController.jumpPressedThisFrame = jumpAction.IsPressed();
        Debug.DrawRay(spawner.transform.position, moveValue);

    }
}
