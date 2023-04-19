using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        //reload
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerState>().Death();
            Debug.Log("Hit");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerState>().Death();
        }
    }
}
