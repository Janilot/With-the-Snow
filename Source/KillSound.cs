using UnityEngine;

public class KillSound : MonoBehaviour
{
    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(!source.isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
