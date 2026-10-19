using UnityEngine;

public class EnemySpawnTrigger : MonoBehaviour
{
    
    public Spawner spawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() != null)
        {
            spawner.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() != null)
        {
        spawner.gameObject.SetActive(false);

        }
    }
}
