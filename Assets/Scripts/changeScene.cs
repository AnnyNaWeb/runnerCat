using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{

    public string nextSceneName;

    public void NextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    public void DeleteCollection()
    {
        PlayerPrefs.DeleteAll();
    }
}
