using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {   
        if(other.CompareTag("Wall")){
            print("You walked into a wall");
        }else {
            Destroy(other.gameObject);
            Destroy(gameObject);
        } 
    }
}
