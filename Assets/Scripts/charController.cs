﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charController : MonoBehaviour {

    public float movementSpeed;
    public float yMaximo;
    public float yMinimo;
    public static int stickerCount;
    public Text sticker;

    Rigidbody2D rb;

    //public Transform direcaoAtual;
    // public Transform esquerda;
    //   public Transform direita;

    //public SpriteRenderer sr;
    //SpriteRenderer sr;

    void Start () {
        rb = GetComponent<Rigidbody2D> ();
        stickerCount = 0;
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

    private void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.CompareTag ("sticker")) {
            Destroy (other.gameObject);
            stickerCount++;
            sticker.text = "  " + stickerCount.ToString ();
            //  stiker.text()
        }
    }
}