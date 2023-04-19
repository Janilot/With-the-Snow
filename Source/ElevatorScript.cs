using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    public Transform player;
    public Transform elevatorswitch;
    public Transform downpos;
    public Transform upperpos;

    public bool isOnPlatform = true;

    public float speed;
    bool isElevatorDown;

    // Update is called once per frame
    void Update()
    {
        StartElavator();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Snowball" || (other.gameObject.tag == "Player"))
        {
            other.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Snowball" || (other.gameObject.tag == "Player"))
        {
            other.transform.parent = null;
        }
    }

    void StartElavator()
    {
        if (Vector3.Distance(player.position, elevatorswitch.position) < 3.5f && Input.GetKey("z"))
        {
            if(transform.position.y <= downpos.position.y)
            {
                isElevatorDown = true;
            }
            else if(transform.position.y >= upperpos.position.y)
            {
                isElevatorDown = false;
            }

            if(isElevatorDown)
            {
                transform.position = Vector3.MoveTowards(transform.position, upperpos.position, speed * Time.deltaTime);
            }

            else
            {
                transform.position = Vector3.MoveTowards(transform.position, downpos.position, speed * Time.deltaTime);
            }
        }
    }

    



}
