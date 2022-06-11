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
    public Transform punch1;
    public int Lives = 1;
    public float punch1Radius;
    public float jumpForce = 15f;
    public bool is_ground = true;
    public AudioSource audioSourseHero;
    public AudioClip[] otherClips;

    public LayerMask enemy;
    
    
    void Start()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        audioSourseHero = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        Wolk();
        FlipSprite();
        anim.SetBool("onGround", is_ground);
        if(Input.GetButtonDown("Jump") && is_ground){
            Jump();
        }

        if(Input.GetMouseButtonDown(0))
        {   
            //audioSourseHero.Play();
            //anim.SetBool("startHit", true);
            PlayRandomClipSword();
            anim.Play("AttakAnim");
            Collider2D[] enemies = Physics2D.OverlapCircleAll(punch1.position, punch1Radius, enemy);

            for (int i = 0; i < enemies.Length; i++){
                enemies[i].GetComponent<StaticEnemy>().TakeDamage();
                print(enemies);
            }
            //anim.SetBool("startHit", false);
            print("punch width Sound");
        }
    }
    void Wolk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2 (moveVector.x * speed, rb.velocity.y);
    }

    void PlayRandomClipSword(){
        //if(audioSourseHero.isPlaying) return;
        audioSourseHero.clip = otherClips[Random.Range(0, otherClips.Length - 1)];
        audioSourseHero.Play();
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
        if(Lives <= 0){
            Die();
        }
    }

}
