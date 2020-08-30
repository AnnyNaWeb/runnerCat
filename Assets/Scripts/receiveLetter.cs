using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class receiveLetter : MonoBehaviour {

    public static int letterNumber;

    SpriteRenderer spr;
    public GameObject button;

    public Sprite newSprite;

    void Start () {

        spr = GetComponent<SpriteRenderer> ();

        Debug.Log ("Mail Number: " + (letterNumber == (PlayerPrefs.GetInt ("Collection"))));
        Debug.Log ("letterNumber: " + letterNumber);

        if (letterNumber <= (PlayerPrefs.GetInt ("Collection"))) {
            spr.sprite = newSprite;
            button.SetActive (true);
        }

    }

}