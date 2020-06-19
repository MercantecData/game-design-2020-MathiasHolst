using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float coolDown = 1;
    private float coolDownTimer;
    public float speed = 4;
    public Transform Gun;
    public GameObject skudPrefab;
    public float force = 20f;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var inputHorizontal = Input.GetAxis("Horizontal");
        var inputVertical = Input.GetAxis("Vertical");


        Vector2 position = transform.position;
        position.x += speed * Time.deltaTime * inputHorizontal; //frame time independant
        position.y += speed * Time.deltaTime * inputVertical;
        rigidbody.MovePosition(position);

        if(coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        } else if(coolDownTimer < 0){
            coolDownTimer = 0;           
        }

        if(Input.GetButtonDown("Shoot") && coolDownTimer == 0)
        {
            Fire();
            coolDownTimer = coolDown;
        }
        
    }

    void Fire()
    {
        GameObject skud = Instantiate(skudPrefab, Gun.position, Gun.rotation);
        Rigidbody2D rigid = skud.GetComponent<Rigidbody2D>();
        rigid.velocity = skud.transform.up * 10;
    }
    /*
     * Box collider 2D til at lave mur objekter som blokere brugeren
     * Box collider 2D til at få spilleren til ikke at kunne gå igennem vægge.
     * Rigidbody 2D skal tilføjes til spilleren og husk at slå gravity fra da det er et topdown spil
     * 
     * Et gameobjekt samler på components
     * En scene samler alle gameojbekter i den scene
     * Et game samler på alle scener
     * 
     * ---MonoBehaviour Lifecycle---
     * Start
     * Update
     * LateUpdate
     * OnMouseXXX
     * FixedUpadte
     * https://docs.unity3d.com/Manual/ExecutionOrder.html
     * ---Mads bruger disse til at lave spil---
    */
}
