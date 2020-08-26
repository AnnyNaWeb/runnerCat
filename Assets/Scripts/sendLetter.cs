using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendLetter : MonoBehaviour
{

    public int mailNumber;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerPrefs.SetInt("Collection", mailNumber);
        Debug.Log("Mail Number: " + mailNumber);
    }
}
