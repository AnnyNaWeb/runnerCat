using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charController : MonoBehaviour
{

    public float movementSpeed;

    Rigidbody2D rb;

    //SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Mover();
    }

    void Mover()
    {
        transform.Translate(Vector2.up * Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime);
    }
}
