using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    public GameObject cone;
    public GameObject gato;
    public GameObject outrogato;
    public GameObject life;
    public GameObject sticker;
    public static bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public float yMaximo;
    public float yMinimo;

    void Start () {
        InvokeRepeating ("SpawnCone", spawnTime, spawnDelay);
        InvokeRepeating ("SpawnOtherGato", spawnTime, (spawnDelay + 6F));
        InvokeRepeating ("SpawnGato", spawnTime, (spawnDelay + 3F));
        InvokeRepeating ("SpawnLife", spawnTime, (spawnDelay + 5F));
        InvokeRepeating ("SpawnStickerFoto", spawnTime, (spawnDelay + 5F));

    }

    public void SpawnCone () {

        if (stopSpawning) {
            CancelInvoke ("SpawnCone");

        } else {
            transform.position = new Vector2 (10F, Random.Range (yMaximo, yMinimo));
            Instantiate (gato, transform.position, transform.rotation);
        }

    }
    public void SpawnStickerFoto () {

        if (stopSpawning) {
            CancelInvoke ("SpawnStickerFoto");

        } else {
            transform.position = new Vector2 (17F, Random.Range (yMaximo, yMinimo));
            Instantiate (sticker, transform.position, transform.rotation);
        }

    }
    public void SpawnGato () {

        if (stopSpawning) {
            CancelInvoke ("SpawnGato");
        } else {
            transform.position = new Vector2 (14F, Random.Range (yMaximo, yMinimo));
            Instantiate (cone, transform.position, transform.rotation);
        }

    }

    public void SpawnOtherGato () {

        if (stopSpawning) {
            CancelInvoke ("SpawnOtherGato");
        } else {
            transform.position = new Vector2 (163F, Random.Range (yMaximo, yMinimo));
            Instantiate (outrogato, transform.position, transform.rotation);
        }

    }

    public void SpawnLife () {

        if (stopSpawning) {
            CancelInvoke ("SpawnLife");
        } else {
            transform.position = new Vector2 (12F, Random.Range (yMaximo, yMinimo));
            Instantiate (life, transform.position, transform.rotation);
        }
    }

    void Update () {

    }
}