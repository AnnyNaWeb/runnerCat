using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

    public string nextSceneName;
    //  int mailNumber;

    public void NextScene () {
        SceneManager.LoadScene (nextSceneName);
    }
    public void PlayGame () {
        SceneManager.LoadScene ("playScene");
    }
    public void Credits () {
        SceneManager.LoadScene ("Credits");
    }
    public void TryAgain () {
        SceneManager.LoadScene ("playScene");
    }
    public void BackHome () {
        SceneManager.LoadScene ("mainMenu");
    }
    public void Collections () {
        //  mailNumber = 1;
        //   PlayerPrefs.SetInt ("Collection", mailNumber);
        //    Debug.Log ("Mail Number: " + mailNumber);
        SceneManager.LoadScene ("collectionMenu");
    }

    public void DeleteCollection () {
        PlayerPrefs.DeleteAll ();
    }

}