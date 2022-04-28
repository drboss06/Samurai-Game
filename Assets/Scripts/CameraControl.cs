using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform player;
    public Vector3 pos;
    void Start()
    {
        
    }

    void Update()
    {
        pos = player.position;
        pos.z = -1f;
        
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
    }
}
