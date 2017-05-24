using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Actions : MonoBehaviour
{
    private Rigidbody2D rig;

    public Button Climb;
    public Button Block;
    public Button Push;
    public Button Die;
    public Button Activate;

    //Climb
    private float climbSpeed;
    public bool isClimber;
    public bool btnClimbClicked;

    //Block
    public bool btnBlockClicked;
    public bool isBlock;

    //Push
    public bool isPusher;
    public bool btnPushClicked;

    //Die
    public bool btnDieClicked;

    //Activate
    public bool isActivated;
    public bool btnActivateClicked;

    void Start()
    {
        rig = this.GetComponent<Rigidbody2D>();

        climbSpeed = constantes.CLIMBSPEED;

        btnClimbClicked = constantes.BTNSTART;
        btnBlockClicked = constantes.BTNSTART;
        btnPushClicked = constantes.BTNSTART;
        btnDieClicked = constantes.BTNSTART;
        btnActivateClicked = constantes.BTNSTART;

        isBlock = false;
        isClimber = false;
        isPusher = false;
        isActivated = false;

        Button btnClimb = Climb.GetComponent<Button>();
        Button btnBlock = Block.GetComponent<Button>();
        Button btnPush = Push.GetComponent<Button>();
        Button btnDie = Die.GetComponent<Button>();
        Button btnActivate = Activate.GetComponent<Button>();

        btnClimb.onClick.AddListener(ClimbClicked);
        btnBlock.onClick.AddListener(BlockClicked);
        btnPush.onClick.AddListener(PushClicked);
        btnDie.onClick.AddListener(DieClicked);
        btnActivate.onClick.AddListener(ActivateClicked);
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
            isBlock = true;         
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

        //Activate
        if (btnActivateClicked)
        {
            btnActivateClicked = false;
            isActivated = true;
        }
    }

    void ClimbClicked()
    {
        btnClimbClicked = true;
        btnBlockClicked = false;
        btnPushClicked = false;
        btnDieClicked = false;
        btnActivateClicked = false;

    }

    void BlockClicked()
    {
        btnClimbClicked = false;
        btnBlockClicked = true;
        btnPushClicked = false;
        btnDieClicked = false;
        btnActivateClicked = false;
    }

    void PushClicked()
    {
        btnClimbClicked = false;
        btnBlockClicked = false;
        btnPushClicked = true;
        btnDieClicked = false;
        btnActivateClicked = false;
    }

    void DieClicked()
    {
        btnClimbClicked = false;
        btnBlockClicked = false;
        btnPushClicked = false;
        btnDieClicked = true;
        btnActivateClicked = false;
    }

    void ActivateClicked()
    {
        btnClimbClicked = false;
        btnBlockClicked = false;
        btnPushClicked = false;
        btnDieClicked = false;
        btnActivateClicked = true;
    }
    void OnTriggerStay2D(Collider2D other)
    {
        //Activate
        if (other.tag == "Button" && isActivated == true)
        {
            variables.doorIsActivated = true;
            rig.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        }
    }

}
