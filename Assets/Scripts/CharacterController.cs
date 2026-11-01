//Take input for player
//Aiming, Jumping, Shooting, Moving
//Just calls other methods

using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    InputAction attackAction;
    InputAction moveAimAction;
    

    public Spawner spawner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAimAction = InputSystem.actions.FindAction("Move");
        attackAction = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        spawner.isSpawning = attackAction.IsPressed();

        //Moveaction to aim

        Vector2 moveAimValue = moveAimAction.ReadValue<Vector2>();
        spawner.transform.right = moveAimValue;

        Debug.DrawRay(spawner.transform.position, moveAimValue);

    }
}
