using UnityEngine;

public class EnemySpawnTrigger : MonoBehaviour
{
    
    public Spawner spawner;

    private void Awake()
    {
        spawner.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CharacterController>() != null)
        {
            Debug.Log(gameObject.name + "Detected player!!");
            
            spawner.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<CharacterController>() != null)
        {
            Debug.Log(gameObject.name + "No longer detects playere");
           
            spawner.gameObject.SetActive(false);

        }
    }
}
