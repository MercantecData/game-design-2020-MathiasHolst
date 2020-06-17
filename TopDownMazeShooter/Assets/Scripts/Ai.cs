﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    private string currentState = "Patrol";
    private Transform nextwaypoint;

    public LayerMask mask;

    public float speed = 4;
    public float range = 15;

    public Transform waypoint1;
    public Transform waypoint2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentState == "Patrol")
        {
            Vector2 nextposition = Vector2.MoveTowards(transform.position, nextwaypoint.position, Time.deltaTime * speed);
            transform.position = nextposition;
            if(transform.position == nextwaypoint.position)
            {
                if(nextwaypoint == waypoint1)
                {
                    nextwaypoint = waypoint2;
                } else {
                    nextwaypoint = waypoint1;
                }
                
            }
            if(targetAquired()){
                currentState = "Attack";
            }
            //transform.up = transform.position-((Vector3) nextposition);
        }   
        else if (currentState == "Attack")
        {
            //Shoot
            print("Shoot");

            if(!targetAquired()){
                currentState = "Patrol";
            }
        }
    }

    bool targetAquired() {
        GameObject targetGo = GameObject.FindGameObjectWithTag("Player");
        bool inRange = false;
        bool inVision = false;

        if(Vector2.Distance(targetGo.transform.position, transform.position < range)){
            inRange = true;
        }

        var linecast = Physics2D.Linecast(transform.position, targetGo.transform.position, mask);
        if(linecast.transform == null){
            inVision = true;
        }

        return inRange && inVision;
    }
}