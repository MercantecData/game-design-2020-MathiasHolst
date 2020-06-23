using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    
    public Text points;
    public GameObject onHit;
    private int i = 1;

    void OnTriggerEnter2D(Collider2D other)
    {   
        if(other.CompareTag("Wall")){
            print("You walked into a wall");
        }else {
            GameObject effect = Instantiate(onHit, transform.position, Quaternion.identity);
            Destroy(effect, 1);
            Destroy(other.gameObject);
            Destroy(gameObject);
            points.text = i.ToString();
        } 
    }
}
