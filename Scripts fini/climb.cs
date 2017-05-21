using UnityEngine;
using System.Collections;

//constante
public static readonly float CLIMBSPEED = 3f;
    
//variables
private float climbSpeed;
private bool isClimber;

//Void Start
climbSpeed=constantes.CLIMBSPEED;
isClimber = false;

//Void Update()
void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall" && isClimber == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, climbSpeed);
        }
    }

