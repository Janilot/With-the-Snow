using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaliingSpike : MonoBehaviour
{
    [SerializeField]
    private GameObject FallingSpike;

    [SerializeField]
    private ParticleSystem breakIceParticle;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name.Equals("SinglePlayer"))
            rb.isKinematic = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        //reload
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerState>().Death();
        }
        Instantiate(breakIceParticle, transform.position, Quaternion.identity);

        Destroy(FallingSpike);
        SoundManager.instance.PlaySFX("iceCycle");

    }

}
