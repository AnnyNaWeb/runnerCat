using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelController : MonoBehaviour
{

    public float speed;
    public GameObject Mission;
    public GameObject Player;
    public static bool started;

    void Start()
    {
        started = false;
        
    }
    void PlayGame()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    IEnumerator InitMission(){
        Mission.SetActive(true);
        yield return new WaitForSeconds(5);
        Mission.SetActive(false);
        Player.SetActive(true);
        started = true;
    }
    void Update()
    {
        if(started){
            PlayGame();
        }else {
            Player.SetActive(false);
            StartCoroutine(InitMission());
        }

    }
}
