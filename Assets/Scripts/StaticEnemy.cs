using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEnemy : Entity
{   
    public int Lives = 1;
    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage(1);
            Lives--;
            print("Static enemy Lives " + Lives);
        }

        if (Lives <= 0)
        {
            Die();
        }
    }
}
