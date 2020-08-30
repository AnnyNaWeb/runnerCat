using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerLetter : MonoBehaviour {

    public GameObject LetterOne;
    public GameObject ButtonOne;
    public GameObject ButtonBack;

    public void exibeCarta () {
        LetterOne.SetActive (true);
        ButtonOne.SetActive (false);
        ButtonBack.SetActive (true);
    }

    public void escondeCarta () {
        LetterOne.SetActive (false);
        ButtonOne.SetActive (true);
        ButtonBack.SetActive (false);
    }
}