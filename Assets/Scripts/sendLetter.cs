﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendLetter : MonoBehaviour {

    public static int mailNumber;

    private void OnTriggerEnter2D (Collider2D collision) {
        SendLetter ();
    }

    private void SendLetter () {
        PlayerPrefs.SetInt ("Collection", mailNumber);
        Debug.Log ("Mail Number: " + mailNumber);
    }
}