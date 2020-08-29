﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelController : MonoBehaviour {

    public float speed;
    public GameObject Mission;
    public GameObject Player;
    public GameObject Chao;
    public static bool started;

    public float totalTime;
    public Text tempo;
    private float minutes;
    private float seconds = 60;

    public GameObject itemPrefab;

    void Start () {
        started = false;

    }

    /*  public GameObject GetRandomItem () {
          int c = Mathf.RoundToInt (Random.Range (0, items.Length - 1));
          return items[c];

      }*/

    void PlayGame () {
        totalTime -= Time.deltaTime;
        minutes = (int) (totalTime / 60);
        seconds = (int) (totalTime % 60);
        tempo.text = minutes.ToString () + " : " + seconds.ToString ();

        if (seconds >= 0) {
            transform.Translate (speed * Time.deltaTime, 0, 0);

        } else {
            started = false;
        }
    }

    IEnumerator InitMission () {
        Mission.SetActive (true);
        yield return new WaitForSeconds (5);
        Mission.SetActive (false);
        Player.SetActive (true);
        Chao.SetActive (true);
        started = true;
    }
    void Update () {
        if (started) {
            PlayGame ();
        } else {
            Player.SetActive (false);
            Chao.SetActive (false);
            StartCoroutine (InitMission ());
        }

    }
}