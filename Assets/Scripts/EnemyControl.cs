using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public Rigidbody2D rbPhisic;
    public Transform player;
    public float distanceToPlayer;
    public float speed;
    public float distanceToAgro;
    void Start()
    {
        rbPhisic = GetComponent<Rigidbody2D>();
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
    }

    void HuntToPlayer()
    {
        if(player.position.x < transform.position.x)
        {
            rbPhisic.velocity = new Vector2(speed * -1, 0);
        }else if (player.position.x > transform.position.x)
        {
            rbPhisic.velocity = new Vector2(speed, 0);
        }
    }

    void StopHuntToPlayer()
    {
        rbPhisic.velocity = new Vector2(0, 0);
    }

    void StaticMove(){
        
    }
}
