using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileDataHandler
{
    private string dataDirPath = "";
    private string dataFileName = "";

    public FileDataHandler(string dataDirPath, string dataFileName)
    {
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;

    }

    public StarData Load()
    {
        string fullPath = Path.Combine(dataDirPath, dataFileName);

        StarData loadedData = null;
        if(File.Exists(fullPath))
        {
            try
            {
                //Load the serialized data from the file
                string dataToLoad = "";
                using(FileStream stream = new FileStream(fullPath, FileMode.Open))
                {
                    using(StreamReader reader = new StreamReader(stream))
                    {
                        dataToLoad = reader.ReadToEnd();
                    }
                }

                //deserialize the data from JSON
                loadedData = JsonUtility.FromJson<StarData>(dataToLoad);
            }
            catch (Exception e)
            {
                Debug.LogError("Error occured when trying to load data from file " + fullPath + "\n" + e);
            }
        }
        return loadedData;
    }

    public void Save(StarData data)
    {
        string fullPath = Path.Combine(dataDirPath, dataFileName);
        try
        {
            //create directory path if it doesn't exist
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

            //serialize the game data intpo JSON
            string dataToStore = JsonUtility.ToJson(data, true);

            //write the serialized data to file
            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                using(StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataToStore);
                }
            }
        }
        catch(Exception e)
        {
            Debug.LogError("Error occured when trying to save data to file:" + fullPath + "\n" + e);

        }

    }


}
