using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    
    public Text points;

    private int i = 1;

    void OnTriggerEnter2D(Collider2D other)
    {   
        if(other.CompareTag("Wall")){
            print("You walked into a wall");
        }else {
            Destroy(other.gameObject);
            Destroy(gameObject);
            points.text = i.ToString();
        } 
    }
}
