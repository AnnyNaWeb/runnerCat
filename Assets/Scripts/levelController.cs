using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelController : MonoBehaviour {

    public float speed;
    public GameObject Mission;
    public GameObject Player;
    public GameObject Chao;
    public GameObject Ceu;
    public GameObject Cidade;
    public GameObject Arvores;

    public GameObject Finish;
    public GameObject FinishLetter;
    public GameObject FinishNotLetter;

    public static bool started;
    public bool missionFase;
    public static bool endGame;

    public float totalTime;
    public Text tempo;

    private float minutes;
    private static float seconds = 60;

    //public GameObject itemPrefab;

    void Start () {
        started = false;
        missionFase = true;
        endGame = false;

    }

    /*  public GameObject GetRandomItem () {
          int c = Mathf.RoundToInt (Random.Range (0, items.Length - 1));
          return items[c];

      }*/

    void PlayGame () {

        Player.SetActive (true);
        Chao.SetActive (true);
        Cidade.SetActive (true);
        Arvores.SetActive (true);
        Ceu.SetActive (true);
        totalTime -= Time.deltaTime;
        minutes = (int) (totalTime / 60);
        seconds = (int) (totalTime % 60);
        tempo.text = minutes.ToString () + " : " + seconds.ToString ();

        if (seconds >= 0) {
            transform.Translate (speed * Time.deltaTime, 0, 0);

        } else {
            endGame = true;
        }
    }

    IEnumerator InitMission () {
        Mission.SetActive (true);
        SpawnPoint.stopSpawning = false;
        yield return new WaitForSeconds (10);
        started = true;
        Mission.SetActive (false);

    }

    void FinishGame () {

        if (seconds > 0) {
            SpawnPoint.stopSpawning = true;
            Player.SetActive (false);
            Chao.SetActive (false);
            Arvores.SetActive (false);
            Ceu.SetActive (false);
            Cidade.SetActive (false);
            Finish.SetActive (true);

        } else if (seconds <= 0) {
            Player.SetActive (false);
            Chao.SetActive (false);
            Arvores.SetActive (false);
            Ceu.SetActive (false);
            Cidade.SetActive (false);
            if (charController.stickerCount <= 5) {
                FinishNotLetter.SetActive (true);
            } else {
                FinishLetter.SetActive (true);
            }

        }

    }

    void Update () {

        if (started) {
            PlayGame ();
            if (endGame) {
                FinishGame ();
            }
        } else if (missionFase) {
            Player.SetActive (false);
            Chao.SetActive (false);
            Ceu.SetActive (false);
            Arvores.SetActive (false);
            Cidade.SetActive (false);
            Finish.SetActive (false);
            StartCoroutine (InitMission ());
        }

    }

}