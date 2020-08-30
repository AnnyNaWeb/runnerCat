using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    public GameObject cone;
    public GameObject gato;
    public GameObject outrogato;
    public GameObject life;
    public static bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public float yMaximo;
    public float yMinimo;
    //public GameObject letter;

    void Start () {
        InvokeRepeating ("SpawnCone", spawnTime, spawnDelay);
        InvokeRepeating ("SpawnOtherGato", spawnTime, (spawnDelay + 6F));
        InvokeRepeating ("SpawnGato", spawnTime, (spawnDelay + 3F));
        InvokeRepeating ("SpawnLife", spawnTime, (spawnDelay + 5F));
        //     InvokeRepeating ("Letter", spawnTime, (spawnDelay + 40F));
    }

    /*  public void Letter () {
          transform.position = new Vector2 (11F, Random.Range (yMaximo, yMinimo));
          Instantiate (letter, transform.position, transform.rotation);
          if (stopSpawning) {
              CancelInvoke ("Letter");
          }

      }*/
    public void SpawnCone () {
        transform.position = new Vector2 (10F, Random.Range (yMaximo, yMinimo));
        Instantiate (gato, transform.position, transform.rotation);
        if (stopSpawning) {
            CancelInvoke ("SpawnCone");
        }

    }
    public void SpawnGato () {
        transform.position = new Vector2 (14F, Random.Range (yMaximo, yMinimo));
        Instantiate (cone, transform.position, transform.rotation);
        if (stopSpawning) {
            CancelInvoke ("SpawnGato");
        }

    }

    public void SpawnOtherGato () {
        transform.position = new Vector2 (163F, Random.Range (yMaximo, yMinimo));
        Instantiate (outrogato, transform.position, transform.rotation);
        if (stopSpawning) {
            CancelInvoke ("SpawnOtherGato");
        }

    }

    public void SpawnLife () {
        transform.position = new Vector2 (12F, Random.Range (yMaximo, yMinimo));
        Instantiate (life, transform.position, transform.rotation);
        if (stopSpawning) {
            CancelInvoke ("SpawnLife");
        }
    }

    void Update () {

    }
}