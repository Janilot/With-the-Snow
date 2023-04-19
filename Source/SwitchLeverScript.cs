using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLeverScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player" || other.transform.tag == "Snowball")
        {
            Debug.Log(this.transform.parent.parent.name); //switch object
            switch (transform.parent.parent.gameObject.name)
            {
                case "SwitchDoor":
                    {
                        transform.parent.parent.gameObject.GetComponent<SwitchObjectScript>().CollideLever(other.transform);
                        break;
                    }
                case "SwitchPlatform":
                    {
                        transform.parent.parent.gameObject.GetComponent<SwitchPlatformScript>().CollideLever(other.transform);
                        break;
                    }
                default: break;
            }
        }
    }
}
