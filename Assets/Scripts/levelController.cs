using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelController : MonoBehaviour
{

    public float speed;
    public GameObject Mission;
    public static bool started;

    void Start()
    {
        started = false;
        
    }
    void MoveCarta()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    IEnumerator InitMission(){
        Mission.SetActive(true);
        yield return new WaitForSeconds(5);
        Mission.SetActive(false);
        started = true;
    }
    void Update()
    {
        if(started){
            MoveCarta();
        }else {
            StartCoroutine(InitMission());
        }

    }
}
