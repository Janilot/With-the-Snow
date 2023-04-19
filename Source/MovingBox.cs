using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBox : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            rb.drag = 5;
        }

        if(collision.gameObject.tag == "SwitchPlatform")
        {
            rb.drag = 9;
        }



    }

    public void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            rb.drag = 1;
        }

        if (collision.gameObject.tag == "SwitchPlatform")
        {
            rb.drag = 5;
        }


    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerState>().SetPushStartMotion();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerState>().SetPushEndMotion();
        }
    }

}
