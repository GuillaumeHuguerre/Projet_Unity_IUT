using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Actions : MonoBehaviour {

    public Button Climb;
    public Button Block;
    public Button Push;
    public Button Die;

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

        Button btnClimb = Climb.GetComponent<Button>();
        Button btnBlock = Block.GetComponent<Button>();
        Button btnPush = Push.GetComponent<Button>();
        Button btnDie = Die.GetComponent<Button>();

        btnClimb.onClick.AddListener(ClimbClicked);
        btnBlock.onClick.AddListener(BlockClicked);
        btnPush.onClick.AddListener(PushClicked);
        btnDie.onClick.AddListener(DieClicked);
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
        print("test btn die");
        btnClimbClicked = false;
        btnBlockClicked = false;
        btnPushClicked = false;
        btnDieClicked = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Climb
<<<<<<< HEAD
        //if (other.tag == "Wall" && isClimber == true)
        //{
        //    transform.Translate(Vector3.up * climbSpeed * Time.deltaTime);
        //    GetComponent<Rigidbody2D>().velocity = new Vector2(0, climbSpeed);
        //}
=======
        if (other.tag == "Wall" && isClimber == true)
        {
            print("is climbe == true et contact avec mur");
            transform.Translate(Vector3.up * climbSpeed * Time.deltaTime);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, climbSpeed);
        }
>>>>>>> origin/Nicolas

        //Push
        if (btnPushClicked)
        {            
              
        }
     }
}
