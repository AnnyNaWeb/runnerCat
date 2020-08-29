using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    public GameObject cone;
    public GameObject life;
    public static bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public float yMaximo;
    public float yMinimo;

    void Start () {
        InvokeRepeating ("SpawnCone", spawnTime, spawnDelay);
        InvokeRepeating ("SpawnLife", spawnTime, (spawnDelay + 5F));
    }

    public void SpawnCone () {
        transform.position = new Vector2 (7.9F, Random.Range (yMaximo, yMinimo));
        Instantiate (cone, transform.position, transform.rotation);
        if (stopSpawning) {
            CancelInvoke ("SpawnCone");
        }

    }

    public void SpawnLife () {
        transform.position = new Vector2 (11F, Random.Range (yMaximo, yMinimo));
        Instantiate (life, transform.position, transform.rotation);
        if (stopSpawning) {
            CancelInvoke ("SpawnLife");
        }
    }

    void Update () {

    }
}