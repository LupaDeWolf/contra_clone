using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{

    public Transform playerTransform;
    public float parallaxEffect = 0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position * parallaxEffect;
    }
}
