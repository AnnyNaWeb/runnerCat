using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItem : MonoBehaviour {

    float speed = -5;
    void Update () {
        transform.Translate (speed * Time.deltaTime, 0, 0);
    }
}