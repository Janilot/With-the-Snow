using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadSingleGame()
    {
        SceneManager.LoadScene("SingleGame");
    }
    
    public void LoadMultiGame()
    {
        SceneManager.LoadScene("SingleGame");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!!!");
    }

    private void Start()
    {
        SoundManager.instance.playBGM("MENU");
    }
    private void Update()
    {
        if(Input.GetKey("9"))
        {
            SceneManager.LoadScene("ShaderTest");
        }
        if (Input.GetKey("8"))
            GameManagerScript.instance.SetIsSingle(false); ;

    }
}
