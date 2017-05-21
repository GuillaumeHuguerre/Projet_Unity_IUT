using UnityEngine;
using System.Collections;

public class Actions : MonoBehaviour {

    //Climb
    private float climbSpeed;
    public bool isClimber;
    public bool btnClimbClicked;

    //Block
    public bool btnBlockClicked;

    //Push
    public bool isPusher;
    public bool btnPushClicked;

    //Die
    public bool btnDieClicked;

    void Start () {
        climbSpeed = constantes.CLIMBSPEED;

        btnClimbClicked = constantes.BTNSTART;
        btnBlockClicked = constantes.BTNSTART;
        btnPushClicked = constantes.BTNSTART;
        btnDieClicked = constantes.BTNSTART;

        isClimber = false;
        isPusher = false;
    }

    void OnMouseDown()
    {
        //Climb
        if (btnClimbClicked)
        {
            isClimber = true;
            btnClimbClicked = false;
        }

        //Block
        if (btnBlockClicked)
        {
            btnBlockClicked = false;
            gameObject.layer = 8;
            //mettre la vitesse à 0
        }

        //Push
        if (btnPushClicked)
        {
            isPusher = true;
            btnPushClicked = false;
        }

        //Die
        if (btnDieClicked)
        {
            btnDieClicked = false;
            Destroy(gameObject);
        }
    }


    void ClimbClicked()
    {
        btnClimbClicked = true;
        btnBlockClicked = false;
        btnPushClicked = false;
        btnDieClicked = false;
    }

    void BlockClicked()
    {
        btnClimbClicked = false;
        btnBlockClicked = true;
        btnPushClicked = false;
        btnDieClicked = false;
    }

    void PushClicked()
    {
        btnClimbClicked = false;
        btnBlockClicked = false;
        btnPushClicked = true;
        btnDieClicked = false;
    }

    void DieClicked()
    {
        btnClimbClicked = false;
        btnBlockClicked = false;
        btnPushClicked = false;
        btnDieClicked = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Climb
        if (other.tag == "Wall" && isClimber == true)
        {
            transform.Translate(Vector3.up * climbSpeed * Time.deltaTime);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, climbSpeed);
        }

        //Push
        if(other.tag == "Box" && isPusher == true)
        {
            //Action pousser
        }
    }
}
