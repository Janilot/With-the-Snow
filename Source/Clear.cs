    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    [SerializeField] private Animator clearAnim;

    protected GameData m_gameData;

    private int lastBuildIndex = 23;
    private int nextSceneLoad;
    private int starScore;
    private int currScene;



    [SerializeField] public GameObject [] Stars;

    public Text clearTime;
    public Text currScore;
    void Start()
    {
        m_gameData = GameObject.Find("GameData").GetComponent<GameData>();

        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void NextScene()
    {
        Time.timeScale = 1f;

        if (SceneManager.GetActiveScene().buildIndex == lastBuildIndex)
        {
            SceneManager.LoadScene(0);
            Debug.Log("End of buildIndex");
        }
        else
        {
            SceneManager.LoadScene(nextSceneLoad);

            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }
    }

    public void PlayAnim()
    {
        clearAnim.Play("ClearAnim", 0, 0f);
        Debug.Log("Animation Played!!");
    }

    public void BacktoMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuTest");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(gameObject.scene.name);
    }

    public void GetClearTime()
    {
        clearTime.text = (m_gameData.GetStageTimer() - 1.0f).ToString("F1");
    }

    public void GetScoreData()
    {
        currScore.text = m_gameData.GetScore().ToString();
        starScore = m_gameData.GetScore();
    }

    public int StarScore()
    {
        return starScore = m_gameData.GetScore();
    }

    public int CurrentScene()
    {
        return currScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void StarCondition()
    {
        if(starScore < 5)
        {
            Stars[0].SetActive(false);
            Stars[1].SetActive(false);
            Stars[2].SetActive(false);
            Debug.Log("three star deactivate");
        }
        else if(starScore >= 5 && starScore < 7)
        {
            Stars[1].SetActive(false);
            Stars[2].SetActive(false);
            Debug.Log("two star deactivate");
        }

        else if(starScore >= 7 && starScore < 10)
        {
            Stars[2].SetActive(false);
            Debug.Log("one star deactivate");
        }
        else
        {
            return;

        }
    }




    public void Acting()
    {
        GetClearTime();
        GetScoreData();
        StarCondition();

        //for saveData
        StarScore();
        CurrentScene();
    }



}
