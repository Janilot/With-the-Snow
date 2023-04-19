using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Rigidbody rb;

    bool alreadyPlayed = false;
    bool alreadyCreated = false;

    public float delayTime;


    [SerializeField]
    private ParticleSystem breakIceParticle;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (0.01 <= delayTime && delayTime <= 0.03)
        {
            if (!alreadyPlayed)
            {
                SoundManager.instance.PlaySFX("fallingPlatform");
                alreadyPlayed = true;
            }
        }

        if(delayTime <= 0)
        {
            if (!alreadyCreated)
            {
                FallingPlatManager.Instance.StartCoroutine("SpawnPlatform", new Vector3(transform.position.x, transform.position.y, transform.position.z));
                alreadyCreated = true;
            }
        }


    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            delayTime -= Time.deltaTime;


            if(delayTime <= 0)
            {
                rb.isKinematic = false;
                rb.useGravity = true;

                Destroy(gameObject, 1f);
            }
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            delayTime -= Time.deltaTime;


            if (delayTime <= 0)
            {
                rb.isKinematic = false;
                rb.useGravity = true;
                Instantiate(breakIceParticle, transform.position, Quaternion.identity);

                Destroy(gameObject, 1f);
            }
        }
    }



}
