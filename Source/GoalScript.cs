    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour, IDataPersistence
{
    [SerializeField] public GameObject ClearPanel;

    private int snowStartBuildIndex = 5;
    private int cityStartBuildIndex = 15;
    private int spiritStartBuildIndex = 23;

    private int lastBuildIndex = 23;
    private int nextSceneLoad;
    private int currScene;

    private int snowScore;


    public void Start()
    {
        currScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;

            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }

            SoundManager.instance.PlaySFX("goal");
            other.transform.GetComponent<SinglePlayerScript>().Goallll(this.transform);
            GameManagerScript.instance.InitializeSavePoint();
            Invoke("OpenPanel", 1);
        }
    }

    private void OpenPanel()
    {
        //Time.timeScale = 0f;
        SoundManager.instance.PlaySFX("clearState");
        ClearPanel.SetActive(true);
        ClearPanel.transform.parent.gameObject.GetComponent<Clear>().PlayAnim();
        ClearPanel.transform.parent.gameObject.GetComponent<Clear>().Acting();
        this.snowScore = ClearPanel.transform.parent.gameObject.GetComponent<Clear>().StarScore();

        DataPersistenceManager.instance.SaveGame();
    }

    public void LoadCollectableData(StarData data)
    {

    }

    public void SaveCollectableData(StarData data)
    {
        //snow
        if(currScene == snowStartBuildIndex && data.snow1 < this.snowScore)
        {
            data.snow1 = this.snowScore;
            Debug.Log("snow1 Data Saved at Goal: " + data.snow1);
        }
        if (currScene == snowStartBuildIndex + 1 && data.snow2 < this.snowScore)
        {
            data.snow2 = this.snowScore;
        }
        if (currScene == snowStartBuildIndex + 2 && data.snow3 < this.snowScore)
        {
            data.snow3 = this.snowScore;
        }
        if (currScene == snowStartBuildIndex + 3 && data.snow4 < this.snowScore)
        {
            data.snow4 = this.snowScore;
        }
        if (currScene == snowStartBuildIndex + 4 && data.snow5 < this.snowScore)
        {
            data.snow5 = this.snowScore;
        }
        if (currScene == snowStartBuildIndex + 5 && data.snow6 < this.snowScore)
        {
            data.snow6 = this.snowScore;
        }
        if (currScene == snowStartBuildIndex + 6 && data.snow7 < this.snowScore)
        {
            data.snow7 = this.snowScore;
        }
        if (currScene == snowStartBuildIndex + 7 && data.snow8 < this.snowScore)
        {
            data.snow8 = this.snowScore;
        }
        if (currScene == snowStartBuildIndex + 8 && data.snow9 < this.snowScore)
        {
            data.snow9 = this.snowScore;
        }
        if (currScene == snowStartBuildIndex + 9 && data.snow10 < this.snowScore)
        {
            data.snow10 = this.snowScore;
        }

        //city
        if (currScene == cityStartBuildIndex && data.city1 < this.snowScore)
        {
            data.city1 = this.snowScore;
        }
        if (currScene == cityStartBuildIndex + 1 && data.city2 < this.snowScore)
        {
            data.city2 = this.snowScore;
        }
        if (currScene == cityStartBuildIndex + 2  && data.city3 < this.snowScore)
        {
            data.city3 = this.snowScore;
        }
        if (currScene == cityStartBuildIndex  + 3 && data.city4 < this.snowScore)
        {
            data.city4 = this.snowScore;
        }
        if (currScene == cityStartBuildIndex + 4 && data.city5 < this.snowScore)
        {
            data.city5 = this.snowScore;
        }
        if (currScene == cityStartBuildIndex + 5 && data.city6 < this.snowScore)
        {
            data.city6 = this.snowScore;
        }
        if (currScene == cityStartBuildIndex + 6 && data.city7 < this.snowScore)
        {
            data.city7 = this.snowScore;
        }
        if (currScene == cityStartBuildIndex + 7 && data.city8 < this.snowScore)
        {
            data.city8 = this.snowScore;
        }
        /*
        if (currScene == cityStartBuildIndex + 8 && data.city9 < this.snowScore)
        {
            data.city9 = this.snowScore;
        }
        if (currScene == cityStartBuildIndex + 9 && data.city10 < this.snowScore)
        {
            data.city10 = this.snowScore;
        }
        */

        //spirit
        if (currScene == spiritStartBuildIndex && data.spirit1 < this.snowScore)
        {
            data.spirit1 = this.snowScore;
        }

    }
}
