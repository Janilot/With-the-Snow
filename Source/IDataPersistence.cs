using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPersistence
{
    void LoadCollectableData(StarData data);

    void SaveCollectableData(StarData data);
}
