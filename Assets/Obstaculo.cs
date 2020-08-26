using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MorreDiabo();
    }
    // Update is called once per frame
    void MorreDiabo()
    {
        Debug.Log("Bateu aqui em mim");
    }
}
