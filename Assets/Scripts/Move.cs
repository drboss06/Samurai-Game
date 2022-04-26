using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 2f;
    public Animator anim;
    public SpriteRenderer sr;
    public float jumpForce = 15f;
    public bool is_ground = true;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Wolk();
        FlipSprite();
        if(Input.GetButtonDown("Jump")){
            Jump();
        }
    }

    // void FixedUpdate()
    // {
    //     if(Input.GetButtonDown("Jump")){
    //         Jump();
    //     }
    // }
    void Wolk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        //rb.velocity = new Vector2 (moveVector.x * speed, moveVector.y);
        rb.velocity = new Vector2 (moveVector.x * speed, rb.velocity.y);
    }

    void Jump()
        {
            // if (Input.GetKeyDown(KeyCode.Space) && is_ground)
            // {
            //     print("jump");
            //     //anim.SetFloat("jumpY", Mathf.Abs(moveVector.y));
            //     //rb.AddForce(new Vector2(0, jumpForce * 10));
            //     rb.AddForce(transform.up * jumpForce, )
            //     //rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            //     //rb.AddForce(Vector2.up * jumpForce);
            //     //rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            // }
            //rb.AddForce(new Vector2(0, jumpForce * 10));
            
            rb.AddForce(Vector2.up * jumpForce * rb.gravityScale);
            print("jump");
        }
    void FlipSprite()
    {
        if(moveVector.x < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "ground") is_ground = true;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "ground") is_ground = false;
    }

}
