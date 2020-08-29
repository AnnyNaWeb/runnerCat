using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charController : MonoBehaviour
{

    public float movementSpeed;
    public float yMaximo;
    public float yMinimo;

    Rigidbody2D rb;

    //public Transform direcaoAtual;
   // public Transform esquerda;
 //   public Transform direita;

    
    public Slider vida;
    public Text morreu;
    //public SpriteRenderer sr;
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

    
    private void OnCollisionEnter2D(Collision2D other){
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
    }


    private void FixedUpdate()
    {
        if(levelController.started){
            Move();
          //  TesteMove();
        }
        
    }

   /* void TesteMove(){
        if(direcaoAtual == esquerda && transform.position == esquerda.position){
            direcaoAtual = direita;
        }

        if(direcaoAtual == direita && transform.position == direita.position){
            direcaoAtual = esquerda;
        }
        transform.position = Vector2.MoveTowards(transform.position, direcaoAtual.position, 10*Time.deltaTime);
       
       if(transform.position.x < direcaoAtual.position.x) {
           sr.flipX = false;}

       else{ sr.flipX = true;}
    }*/

    void Move()
    {
        transform.position = new Vector2(transform.position.x,Mathf.Clamp(transform.position.y, yMinimo, yMaximo));
        transform.Translate(Vector2.up * Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime);



    }
}
