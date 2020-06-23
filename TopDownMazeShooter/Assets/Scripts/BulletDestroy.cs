using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{

    public GameObject onHit;
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(onHit, transform.position, Quaternion.identity);
        Destroy(effect, 1);
        Destroy(gameObject);
    }
}
