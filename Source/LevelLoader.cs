using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class LevelLoader : MonoBehaviour
{
    public Animator transitionAnim;
    public float transitionTime = 1f;

    public void LoadLevel(string levelName)
    {
        StartCoroutine(LoadScene(levelName));
    }

    IEnumerator LoadScene(string name)
    {
        transitionAnim.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(name);
    }
}
