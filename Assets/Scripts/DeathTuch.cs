using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTuch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage(1);
        }
    }
}
