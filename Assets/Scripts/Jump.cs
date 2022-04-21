using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public bool is_ground = false;
    public Rigidbody2D rb;
    public float force = 7f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerStay2D(Collider2D col)
    {               
        if (col.tag == "ground") is_ground = true;      
    }
    void OnTriggerExit2D(Collider2D col)
    {              
        if (col.tag == "ground") is_ground = false;     
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && is_ground)
        {
            print("jump");
            rb.velocity = new Vector2(rb.velocity.x, force);
            //rb.AddForce(new Vector2(0, force * 10));
            //rb.AddForce(Vector2.up * force * 10);
            //rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        }
    }
}
