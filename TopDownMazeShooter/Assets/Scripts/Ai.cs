using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    private string currentState = "Patrol";
    private Transform nextwaypoint;

    public LayerMask mask;

    public float speed = 4;
    public float range = 5;
    public Transform player;
    public Transform waypoint1;
    public Transform waypoint2;
    // Start is called before the first frame update
    void Start()
    {
        nextwaypoint = waypoint1;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentState == "Patrol")
        {
            Vector3 nextposition = Vector3.MoveTowards(transform.position, nextwaypoint.position, Time.deltaTime * speed);
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
            transform.up = transform.position-((Vector3) nextposition);
        }   
        else if (currentState == "Attack")
        {
            //Shoot
            print("GOT EMM");


            if(!targetAquired()){
                currentState = "Patrol";
            }
        }
    }

    bool targetAquired() {
        GameObject target = GameObject.FindGameObjectWithTag("Player");
        bool inRange = false;
        bool inVision = false;

        if(Vector2.Distance(target.transform.position, transform.position) < range){
            inRange = true;
        }

        var linecast = Physics2D.Linecast(transform.position, target.transform.position, mask);
        if(linecast.transform == null){
            inVision = true;
            Vector3.MoveTowards(transform.position, player.position, Time.deltaTime * speed);
        }

        return inRange && inVision;
    }
}
