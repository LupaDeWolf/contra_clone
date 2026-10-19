using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{

    public GameObject prefabToSpawn;

    InputAction attackAction;
    public float timeSinceLastSpawn = 0.0f;
    public float timeBetweenSpawn = 1.0f;

    public bool isSpawning = true;
    
   

    // Update is called once per frame
    void Update()
    {
        
        if (timeSinceLastSpawn > timeBetweenSpawn && isSpawning)
        {
            Instantiate(prefabToSpawn, transform.position, transform.rotation);
            timeSinceLastSpawn = 0.0f;
        }
        timeSinceLastSpawn += Time.deltaTime;
    }
}
