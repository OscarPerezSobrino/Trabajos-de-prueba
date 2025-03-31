using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int speed;
    public Transform puntoA, puntoB;
    private Vector3 currentTarget;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == puntoA.position)
        {
            currentTarget = puntoB.position;
            sr.flipX = true;
        }
        else if (transform.position == puntoB.position)
        {
            currentTarget = puntoA.position;
            sr.flipX = false;
        }

        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime); 
    }
}
