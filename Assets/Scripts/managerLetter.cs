using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerLetter : MonoBehaviour {

    public GameObject LetterOne;
    public GameObject ButtonBack;
    public GameObject catLetter;

    public void exibeCarta () {

        LetterOne.SetActive (true);
        ButtonBack.SetActive (true);
        catLetter.SetActive (true);

    }

    public void escondeCarta () {
        LetterOne.SetActive (false);
        ButtonBack.SetActive (false);
        catLetter.SetActive (false);
    }
}