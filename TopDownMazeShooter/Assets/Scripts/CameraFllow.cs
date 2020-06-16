﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFllow : MonoBehaviour
{
    public Transform player;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var playerPosition = player.position;
        playerPosition.z = transform.position.z;
        transform.position = playerPosition;
    }
}
