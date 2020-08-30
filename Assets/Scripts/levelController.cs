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
    public GameObject Finish;
    public static bool started;
    public bool missionFase;
    public static bool endGame;
    public Text textCanvas;

    public float totalTime;
    public Text tempo;
    private float minutes;
    private float seconds = 60;

    public GameObject itemPrefab;

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
        yield return new WaitForSeconds (5);
        started = true;
        Mission.SetActive (false);

    }

    void FinishGame () {
        SpawnPoint.stopSpawning = true;
        Player.SetActive (false);
        Chao.SetActive (false);
        Ceu.SetActive (false);
        Cidade.SetActive (false);
        Finish.SetActive (true);
        textCanvas.text = "DEU MOLE NÉ AMADA";

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
            Cidade.SetActive (false);
            Finish.SetActive (false);
            StartCoroutine (InitMission ());
        }

    }

}