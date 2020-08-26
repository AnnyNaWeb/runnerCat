using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charController : MonoBehaviour
{

    public float movementSpeed;

    Rigidbody2D rb;

    
    public Slider vida;
    public Text morreu;
    //SpriteRenderer sr;

    void Start()
    {
        vida.value = 3;
        rb = GetComponent<Rigidbody2D>();
        //sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    
    /*private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.name.Equals("obstaculo")){
            if(vida.value > 0){
                vida.value--;
                Debug.Log("COLIDIU NESSA MERDA");
            }
            else{
                morreu.text = "POXA QUE PENA VOCE MORREU NE AMIGA";
            }

        } else if(other.transform.tag == "recupera"){
            if(vida.value < 3){
                vida.value++;
            }

        }
    }*/


    private void FixedUpdate()
    {
        if(levelController.started){
            Move();
        }
        
    }

    void Move()
    {
        transform.Translate(Vector2.up * Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime);
    }
}
