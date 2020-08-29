using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int lifeCount;


    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Life")){
            Destroy(other.gameObject);
            lifeCount++;
            Debug.Log("Coletou Vida Hein");
        }
    }

}
