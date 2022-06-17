using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public Rigidbody2D rbPhisic;
    public Transform player;
    private float distanceToPlayer;
    public float speed;
    public float distanceToAgro;
    public Animator anim;
    public SpriteRenderer sr;
    void Start()
    {
        rbPhisic = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if(distanceToPlayer < distanceToAgro){
            HuntToPlayer();
        }else{
            StopHuntToPlayer();
            StaticMove();
        }

        if (rbPhisic.velocity.x > 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }

    void HuntToPlayer()
    {
        if(player.position.x < transform.position.x)
        {
            rbPhisic.velocity = new Vector2(speed * -1, 0);
            anim.SetFloat("EnemyMoveX", Mathf.Abs(rbPhisic.velocity.x));
        }
        else if (player.position.x > transform.position.x)
        {
            rbPhisic.velocity = new Vector2(speed, 0);
            anim.SetFloat("EnemyMoveX", Mathf.Abs(rbPhisic.velocity.x));
        }
    }

    void StopHuntToPlayer()
    {
        rbPhisic.velocity = new Vector2(0, 0);
    }

    void StaticMove(){
        
    }
}
