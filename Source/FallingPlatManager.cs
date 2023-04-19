using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatManager : MonoBehaviour
{
    public static FallingPlatManager Instance = null;

    public float respawnTime;
    public Vector3 p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20;


    [SerializeField]
    GameObject FallingPlatform;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(FallingPlatform, p1, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p2, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p3, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p4, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p5, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p6, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p7, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p8, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p9, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p10, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p11, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p12, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p13, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p14, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p15, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p16, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p17, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p18, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p19, FallingPlatform.transform.rotation);
        Instantiate(FallingPlatform, p20, FallingPlatform.transform.rotation);
    }


    IEnumerator SpawnPlatform(Vector3 spawnPosition)
    {
        yield return new WaitForSeconds(respawnTime);
        Instantiate(FallingPlatform, spawnPosition, FallingPlatform.transform.rotation);
    }
}
