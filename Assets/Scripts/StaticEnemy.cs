using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEnemy : Entity
{   
    public int Lives = 1;
    public bool onMuve = true;
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // moveVector.x = Input.GetAxis("Horizontal");
        // anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        // rb.velocity = new Vector2 (moveVector.x * speed, rb.velocity.y);
    }
    public void OnCollisionEnter2D(Collision2D col)
    {   
        
        if(col.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage(1);
            //Lives--;
            print("Static enemy Lives " + Lives);
        }

        if (Lives <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(){
        Lives -= 1;

        print("Static enemy Lives " + Lives);
        if (Lives <= 0){
            Die();
        }
    }
}
