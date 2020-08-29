using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public Slider lifeCount;

    private void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.CompareTag ("obstaculo")) {
            Destroy (other.gameObject);
            if (lifeCount.value > 0) {
                lifeCount.value--;
            } else {
                levelController.endGame = true;
            }

        } else if (other.gameObject.CompareTag ("Life")) {
            Destroy (other.gameObject);
            if (lifeCount.value < 10) {
                lifeCount.value++;
            }
        }
    }

}