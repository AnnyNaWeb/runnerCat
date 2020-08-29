using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charController : MonoBehaviour {

    public float movementSpeed;
    public float yMaximo;
    public float yMinimo;

    Rigidbody2D rb;

    //public Transform direcaoAtual;
    // public Transform esquerda;
    //   public Transform direita;

    //public SpriteRenderer sr;
    //SpriteRenderer sr;

    void Start () {
        rb = GetComponent<Rigidbody2D> ();
        //sr = GetComponent<SpriteRenderer>();
    }

    void Update () {

    }

    private void FixedUpdate () {
        if (levelController.started) {
            Move ();
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

    void Move () {
        transform.position = new Vector2 (transform.position.x, Mathf.Clamp (transform.position.y, yMinimo, yMaximo));
        transform.Translate (Vector2.up * Input.GetAxisRaw ("Vertical") * movementSpeed * Time.deltaTime);

    }
}