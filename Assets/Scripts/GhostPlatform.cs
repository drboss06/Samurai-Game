using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPlatform : MonoBehaviour
{
    public CompositeCollider2D col;
    public GameObject player;
    void Start()
    {
        col = GetComponent<CompositeCollider2D>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            col.isTrigger = true;
        }

        if(Input.GetKeyUp(KeyCode.S)){
            col.isTrigger = false;
        }
    }
}
