using Microsoft.Extensions.DependencyInjection;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float jumpSpeed = 20f;



    public bool isGrounded = false;
    private Rigidbody2D rb;

    public Vector2 moveInput;

    public bool jumpRequested = false;

    private void Awake()
    {

        rb = GetComponent<Rigidbody2D>();
    }




    // Update is called once per frame
    void Update()
    {



        rb.linearVelocityX = (moveInput.x * moveSpeed);


        if (jumpRequested) jump();
    }

    public void jump()
    {
        if (isGrounded)
        {

            rb.linearVelocityY = jumpSpeed;
            jumpRequested = false;

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
