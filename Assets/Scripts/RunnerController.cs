using UnityEngine;

public class RunnerController : MonoBehaviour
{

    public CharacterMovement movement;
    int terrainLayerMask;
    public float lookAheadDistance = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = GetComponent<CharacterMovement>();
        terrainLayerMask = LayerMask.GetMask("Terrain");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D rayCollision = Physics2D.CapsuleCast(
            transform.position, 
            new Vector2(0.1f, 0.2f), 
            CapsuleDirection2D.Vertical, 
            0, 
            movement.moveInput, 
            lookAheadDistance, 
            terrainLayerMask
            );
        bool obstacleAhead = rayCollision.collider != null;

        if( obstacleAhead )
        {
            movement.moveInput *= -1;

        }
    }
}
