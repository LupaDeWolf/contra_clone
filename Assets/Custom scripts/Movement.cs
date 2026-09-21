using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    // These variables are to hold the Action references
    InputAction moveAction;

    private void Start()
    {
        // Find the references to the "Move" and "Jump" actions
        moveAction = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
        // Read the "Move" action value, which is a 2D vector
        // and the "Jump" action state, which is a boolean value

        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        // your movement code here
        transform.Translate(new Vector3(moveValue.x, moveValue.y, 0));
    }
}