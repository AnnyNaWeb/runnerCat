using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public Slider lifeCount;
    public Text textCanvas;

    private void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.CompareTag ("obstaculo")) {
            Destroy (other.gameObject);
            if (lifeCount.value > 0) {
                lifeCount.value--;
            } else {
                textCanvas.text = "MORREU NÉ";
            }

        } else if (other.gameObject.CompareTag ("Life")) {
            Destroy (other.gameObject);
            if (lifeCount.value < 10) {
                lifeCount.value++;
            }
        }
    }

}