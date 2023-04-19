using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataPersistenceManager : MonoBehaviour
{
    [Header("File Storage Config")]

    [SerializeField] private string fileName;
    private StarData starData;
    private List<IDataPersistence> dataPersistenceObjects;
    private FileDataHandler dataHandler;

    public static DataPersistenceManager instance { get; private set; }

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("Found more than one Data Persistence Manager in this scene.");
        }
        instance = this;
    }

    private void Start()
    {
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
        this.dataPersistenceObjects = FindAllDataPersistenceObjects();
        LoadGame();
    }


    public void NewGame()
    {
        this.starData = new StarData();
    }
    public void LoadGame()
    {
        //Load any saved data file using data handler
        this.starData = dataHandler.Load(); //if file X exist, return null

        //if no data loaded, initialize new game
        if(this.starData == null)
        {
            Debug.Log("No data was found. Initializing data to default");
            NewGame();
        }
        //push the loaded data to all other scripts that need
        foreach(IDataPersistence dataPersistenceObj in dataPersistenceObjects)
        {
            dataPersistenceObj.LoadCollectableData(starData);
        }

        //Debug.Log("data Load: " + starData.snowScore);

    }
    public void SaveGame()
    {
        //pass the data to other scripts so they can update it
        foreach(IDataPersistence dataPersistenceObj in dataPersistenceObjects)
        {
            dataPersistenceObj.SaveCollectableData(starData);
        }

        //save that data to a file using data handler
        dataHandler.Save(starData);

        Debug.Log("data Saved at DPM: " + starData.city1);
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }

    private List<IDataPersistence> FindAllDataPersistenceObjects()
    {
        IEnumerable<IDataPersistence> dataPersistnceObjects = FindObjectsOfType<MonoBehaviour>()
            .OfType<IDataPersistence>();

        return new List<IDataPersistence>(dataPersistnceObjects);
    }
}
