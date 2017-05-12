using UnityEngine;
using System.Collections;

//constante
public static readonly float climbSpeed =3f;
public static readonly bool isClimber =false;

//variables
private float climbSpeed;
private bool isClimber;

//Void Start
climbSpeed=constantes.CLIMBSPEED;
isClimber=constantes.ISCLIMBER;

//Void Update()
void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall" && isClimber == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, climbSpeed);
        }
    }

