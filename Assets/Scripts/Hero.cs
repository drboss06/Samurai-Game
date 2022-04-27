using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Entity
{
    public static Hero Instance {get; set;}
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 2f;
    public Animator anim;
    public SpriteRenderer sr;
    public float jumpForce = 15f;
    public bool is_ground = true;
    public int Lives = 1;
    
    
    void Start()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Wolk();
        FlipSprite();
        anim.SetBool("onGround", is_ground);
        if(Input.GetButtonDown("Jump") && is_ground){
            Jump();
        }
    }
    void Wolk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2 (moveVector.x * speed, rb.velocity.y);
    }

    void Jump()
        {   
            moveVector.y = Input.GetAxis("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * rb.gravityScale);
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

    public void GetDamage(int Damage)
    {
        Lives -= Damage;
        print(Lives);
    }

}
