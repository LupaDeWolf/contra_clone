using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{

    public GameObject prefabToSpawn;

    InputAction attackAction;
    public float timeSinceLastSpawn = 0.0f;
    public float timeBetweenSpawn = 1.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (attackAction.IsPressed() && timeSinceLastSpawn > timeBetweenSpawn)
        {
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            timeSinceLastSpawn = 0.0f;
        }
        timeSinceLastSpawn += Time.deltaTime;
    }
}
