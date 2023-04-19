using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretScript : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    float TimeBetween;
    public float startTimebetween;

    [SerializeField] ParticleSystem particleName = null;

    public static AudioClip fire;




    // Start is called before the first frame update
    void Start()
    {
        TimeBetween = startTimebetween;

        fire = Resources.Load<AudioClip>("shot");
    }

    // Update is called once per frame
    void Update()
    {
        //sound



        if(TimeBetween <= 0)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            this.GetComponent<AudioSource>().PlayOneShot(fire);
            TimeBetween = startTimebetween;
            particleName.Play();
        }
        else
        {
            TimeBetween -= Time.deltaTime;
        }
    }
}
