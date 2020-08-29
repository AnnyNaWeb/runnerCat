using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    public GameObject spawn;
    public static bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public float yMaximo;
    public float yMinimo;

    void Start () {
        InvokeRepeating ("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject () {
        transform.position = new Vector2 (7.9F, Random.Range (yMaximo, yMinimo));
        Instantiate (spawn, transform.position, transform.rotation);

        if (stopSpawning) {
            CancelInvoke ("SpawnObject");
        }

    }
    void Update () {

    }
}