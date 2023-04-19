using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadScript : MonoBehaviour
{
    [SerializeField] private Animator JumpPadAnim;

    [Range(0, 50)]
    public float bounceHeight;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Snowball"))
        {
            GameObject bouncer = collision.gameObject;
            Rigidbody rb = bouncer.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(rb.velocity.x, bounceHeight, 0);
            SoundManager.instance.PlaySFX("jumpPad");
            //rb.AddForce(Vector3.up * bounceHeight);

            JumpPadAnim.Play("JumpPad", 0, 0f);
        }
        
    }
}
