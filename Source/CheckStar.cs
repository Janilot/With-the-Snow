using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStar : MonoBehaviour, IDataPersistence
{
    [SerializeField] private string id;

    [ContextMenu("Generate guid for id")]

    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    private bool collected = false;

    public void LoadCollectableData(StarData data)
    {
        data.starsCollected.TryGetValue(id, out collected);
        if(collected)
        {
            this.gameObject.SetActive(false);
        }
    }
    public void SaveCollectableData(StarData data)
    {
        if(data.starsCollected.ContainsKey(id))
        {
            data.starsCollected.Remove(id);
        }
        data.starsCollected.Add(id, collected);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Snowball")
        {
            collected = true;
        }
    }

}
