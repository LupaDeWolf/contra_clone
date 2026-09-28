using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 1f;
    private PlayerControls playerControls;
    private Vector2 movement;
    private Rigidbody2D rigidBody;

    private void Awake()
    {
        playerControls = new PlayerControls();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }


    // Update is called once per frame
    void Update()
    {
        movement = playerControls.Movement.Move.ReadValue<Vector2>();
        rigidBody.MovePosition(rigidBody.position + movement *  moveSpeed * Time.fixedDeltaTime);
    }
}
