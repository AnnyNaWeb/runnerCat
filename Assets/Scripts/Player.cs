using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public Slider lifeCount;
    //public GameObject Sticker;
    public static int countSticker;

    //se coletar mais de 5 e terminar no tempo, habilita carta
    //se coletar menos de 5 e terminar no tempo, não habilita carta
    //se bater e perder muita vida, tente novamente

    private void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.CompareTag ("obstaculo")) {
            Destroy (other.gameObject);
            if (lifeCount.value > 0) {
                lifeCount.value--;
            } else {
                levelController.endGame = true;
            }

        } else if (other.gameObject.CompareTag ("recupera")) {
            Destroy (other.gameObject);
            if (lifeCount.value < 10) {
                lifeCount.value++;
            }
        }
    }

}