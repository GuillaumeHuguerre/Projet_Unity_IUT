using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Actions : MonoBehaviour
{
    private Rigidbody2D rig;

<<<<<<< HEAD
<<<<<<< HEAD

    public GameObject randomSong;


=======
>>>>>>> refs/remotes/origin/Guillaume
    public GameObject score;

=======
>>>>>>> refs/remotes/origin/Vincent_LAURENT
    public Button Climb;
    public Button Block;
    public Button Push;
    public Button Die;
    public Button Activate;
<<<<<<< HEAD
    public Button Jeter;
    public Button Casser;
    public Button Build;
    public Button Miner;
    public Button Creuser;


    public bool isClimber;
    public bool isBlock;
    public bool isPusher;
    public bool isActivated;
    public bool isJeter;
    public bool isCasser;
    public bool isBuild;
    public bool isMiner;
    public bool isCreuser;

    void Start()
    {
<<<<<<< HEAD

=======
>>>>>>> refs/remotes/origin/Guillaume
        rig = this.GetComponent<Rigidbody2D>();

=======

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

>>>>>>> refs/remotes/origin/Vincent_LAURENT
        isBlock = false;
        isClimber = false;
        isPusher = false;
        isActivated = false;
<<<<<<< HEAD
        isJeter = false;
        isCasser = false;
        isBuild = false;
        isMiner = false;
        isCreuser = false;
=======
>>>>>>> refs/remotes/origin/Vincent_LAURENT

        Button btnClimb = Climb.GetComponent<Button>();
        Button btnBlock = Block.GetComponent<Button>();
        Button btnPush = Push.GetComponent<Button>();
        Button btnDie = Die.GetComponent<Button>();
        Button btnActivate = Activate.GetComponent<Button>();
<<<<<<< HEAD
        Button btnJeter = Jeter.GetComponent<Button>();
        Button btnCasser = Casser.GetComponent<Button>();
        Button btnBuild = Build.GetComponent<Button>();
        Button btnMiner = Miner.GetComponent<Button>();
        Button btnCreuser = Creuser.GetComponent<Button>();
=======
>>>>>>> refs/remotes/origin/Vincent_LAURENT

        btnClimb.onClick.AddListener(ClimbClicked);
        btnBlock.onClick.AddListener(BlockClicked);
        btnPush.onClick.AddListener(PushClicked);
        btnDie.onClick.AddListener(DieClicked);
        btnActivate.onClick.AddListener(ActivateClicked);
<<<<<<< HEAD
        btnJeter.onClick.AddListener(JeterClicked);
        btnCasser.onClick.AddListener(CasserClicked);
        btnBuild.onClick.AddListener(BuildClicked);
        btnMiner.onClick.AddListener(MinerClicked);
        btnCreuser.onClick.AddListener(CreuserClicked);
=======
>>>>>>> refs/remotes/origin/Vincent_LAURENT
    }

    void OnMouseDown()
    {
<<<<<<< HEAD
        if (!isBlock)
        {
            if (!isJeter)
<<<<<<< HEAD
            {

=======
            { 
>>>>>>> refs/remotes/origin/Guillaume
                if (variables.btnClimbClicked)
                {
                    isClimber = true;
                }

                if (variables.btnBlockClicked)
                {
                    isBlock = true;
                }

                if (variables.btnPushClicked)
                {
                    isPusher = true;
                }



                if (variables.btnActivateClicked)
                {
                    isActivated = true;
                }
                if (variables.btnJeterClicked)
                {
                    isJeter = true;
                }

                if (variables.btnCasserClicked)
                {
                    isCasser = true;
                }

                if (variables.btnBuildClicked)
                {
                    isBuild = true;
                }

                if (variables.btnMinerClicked)
                {
                    isMiner = true;
                }

                if (variables.btnCreuserClicked)
                {
                    isCreuser = true;
                }
            }
        }
        if (variables.btnDieClicked)
        {
            score.GetComponent<Score>().Death();
<<<<<<< HEAD
            new WaitForSecondsRealtime(2);
            Destroy(gameObject);

=======
            Destroy(gameObject);
>>>>>>> refs/remotes/origin/Guillaume
=======
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
>>>>>>> refs/remotes/origin/Vincent_LAURENT
        }
    }

    void ClimbClicked()
    {
<<<<<<< HEAD
        Build.GetComponent<Image>().color = Color.white;
        Miner.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Casser.GetComponent<Image>().color = Color.white;
        Jeter.GetComponent<Image>().color = Color.white;
        Activate.GetComponent<Image>().color = Color.white;
        Die.GetComponent<Image>().color = Color.white;
        Push.GetComponent<Image>().color = Color.white;
        Block.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Climb.GetComponent<Image>().color = Color.red;
        variables.btnClimbClicked = true;
        variables.btnBlockClicked = false;
        variables.btnPushClicked = false;
        variables.btnDieClicked = false;
        variables.btnActivateClicked = false;
        variables.btnJeterClicked = false;
        variables.btnCasserClicked = false;
        variables.btnBuildClicked = false;
        variables.btnMinerClicked = false;
        variables.btnCreuserClicked = false;
=======
        btnClimbClicked = true;
        btnBlockClicked = false;
        btnPushClicked = false;
        btnDieClicked = false;
        btnActivateClicked = false;
>>>>>>> refs/remotes/origin/Vincent_LAURENT

    }

    void BlockClicked()
    {
<<<<<<< HEAD
        Build.GetComponent<Image>().color = Color.white;
        Miner.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Casser.GetComponent<Image>().color = Color.white;
        Jeter.GetComponent<Image>().color = Color.white;
        Activate.GetComponent<Image>().color = Color.white;
        Die.GetComponent<Image>().color = Color.white;
        Push.GetComponent<Image>().color = Color.white;
        Block.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Climb.GetComponent<Image>().color = Color.white;
        Block.GetComponent<Image>().color = Color.red;
        variables.btnBlockClicked = true;
        variables.btnClimbClicked = false;
        variables.btnPushClicked = false;
        variables.btnDieClicked = false;
        variables.btnActivateClicked = false;
        variables.btnJeterClicked = false;
        variables.btnCasserClicked = false;
        variables.btnBuildClicked = false;
        variables.btnMinerClicked = false;
        variables.btnCreuserClicked = false;
=======
        btnClimbClicked = false;
        btnBlockClicked = true;
        btnPushClicked = false;
        btnDieClicked = false;
        btnActivateClicked = false;
>>>>>>> refs/remotes/origin/Vincent_LAURENT
    }

    void PushClicked()
    {
<<<<<<< HEAD
        Climb.GetComponent<Image>().color = Color.white;
        Build.GetComponent<Image>().color = Color.white;
        Miner.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Casser.GetComponent<Image>().color = Color.white;
        Jeter.GetComponent<Image>().color = Color.white;
        Activate.GetComponent<Image>().color = Color.white;
        Die.GetComponent<Image>().color = Color.white;
        Push.GetComponent<Image>().color = Color.white;
        Block.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Push.GetComponent<Image>().color = Color.red;
        variables.btnPushClicked = true;
        variables.btnClimbClicked = false;
        variables.btnBlockClicked = false;
        variables.btnDieClicked = false;
        variables.btnActivateClicked = false;
        variables.btnJeterClicked = false;
        variables.btnCasserClicked = false;
        variables.btnBuildClicked = false;
        variables.btnMinerClicked = false;
        variables.btnCreuserClicked = false;

=======
        btnClimbClicked = false;
        btnBlockClicked = false;
        btnPushClicked = true;
        btnDieClicked = false;
        btnActivateClicked = false;
>>>>>>> refs/remotes/origin/Vincent_LAURENT
    }

    void DieClicked()
    {
<<<<<<< HEAD
        Build.GetComponent<Image>().color = Color.white;
        Miner.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Casser.GetComponent<Image>().color = Color.white;
        Jeter.GetComponent<Image>().color = Color.white;
        Activate.GetComponent<Image>().color = Color.white;
        Push.GetComponent<Image>().color = Color.white;
        Block.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Climb.GetComponent<Image>().color = Color.white;
        Die.GetComponent<Image>().color = Color.red;
        variables.btnDieClicked = true;
        variables.btnClimbClicked = false;
        variables.btnBlockClicked = false;
        variables.btnPushClicked = false;
        variables.btnActivateClicked = false;
        variables.btnJeterClicked = false;
        variables.btnCasserClicked = false;
        variables.btnBuildClicked = false;
        variables.btnMinerClicked = false;
        variables.btnCreuserClicked = false;
=======
        btnClimbClicked = false;
        btnBlockClicked = false;
        btnPushClicked = false;
        btnDieClicked = true;
        btnActivateClicked = false;
>>>>>>> refs/remotes/origin/Vincent_LAURENT
    }

    void ActivateClicked()
    {
<<<<<<< HEAD
        Build.GetComponent<Image>().color = Color.white;
        Miner.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Casser.GetComponent<Image>().color = Color.white;
        Jeter.GetComponent<Image>().color = Color.white;
        Die.GetComponent<Image>().color = Color.white;
        Push.GetComponent<Image>().color = Color.white;
        Block.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Climb.GetComponent<Image>().color = Color.white;
        Activate.GetComponent<Image>().color = Color.red;
        variables.btnActivateClicked = true;
        variables.btnClimbClicked = false;
        variables.btnBlockClicked = false;
        variables.btnPushClicked = false;
        variables.btnDieClicked = false;
        variables.btnJeterClicked = false;
        variables.btnCasserClicked = false;
        variables.btnBuildClicked = false;
        variables.btnMinerClicked = false;
        variables.btnCreuserClicked = false;
    }
    void JeterClicked()
    {
        Build.GetComponent<Image>().color = Color.white;
        Miner.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Casser.GetComponent<Image>().color = Color.white;
        Activate.GetComponent<Image>().color = Color.white;
        Die.GetComponent<Image>().color = Color.white;
        Push.GetComponent<Image>().color = Color.white;
        Block.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Climb.GetComponent<Image>().color = Color.white;
        Jeter.GetComponent<Image>().color = Color.red;
        variables.btnClimbClicked = false;
        variables.btnBlockClicked = false;
        variables.btnPushClicked = false;
        variables.btnDieClicked = false;
        variables.btnActivateClicked = false;
        variables.btnCasserClicked = false;
        variables.btnBuildClicked = false;
        variables.btnMinerClicked = false;
        variables.btnCreuserClicked = false;
        variables.btnJeterClicked = true;
    }

    void CasserClicked()
    {
        Build.GetComponent<Image>().color = Color.white;
        Miner.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Jeter.GetComponent<Image>().color = Color.white;
        Activate.GetComponent<Image>().color = Color.white;
        Die.GetComponent<Image>().color = Color.white;
        Push.GetComponent<Image>().color = Color.white;
        Block.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Climb.GetComponent<Image>().color = Color.white;
        Casser.GetComponent<Image>().color = Color.red;
        variables.btnCasserClicked = true;
        variables.btnClimbClicked = false;
        variables.btnBlockClicked = false;
        variables.btnPushClicked = false;
        variables.btnDieClicked = false;
        variables.btnActivateClicked = false;
        variables.btnJeterClicked = false;
        variables.btnBuildClicked = false;
        variables.btnMinerClicked = false;
        variables.btnCreuserClicked = false;
    }

    void BuildClicked()
    {
        Miner.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Casser.GetComponent<Image>().color = Color.white;
        Jeter.GetComponent<Image>().color = Color.white;
        Activate.GetComponent<Image>().color = Color.white;
        Die.GetComponent<Image>().color = Color.white;
        Push.GetComponent<Image>().color = Color.white;
        Block.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Climb.GetComponent<Image>().color = Color.white;
        Build.GetComponent<Image>().color = Color.red;
        variables.btnBuildClicked = true;
        variables.btnClimbClicked = false;
        variables.btnBlockClicked = false;
        variables.btnPushClicked = false;
        variables.btnDieClicked = false;
        variables.btnActivateClicked = false;
        variables.btnJeterClicked = false;
        variables.btnCasserClicked = false;
        variables.btnMinerClicked = false;
        variables.btnCreuserClicked = false;

    }

    void MinerClicked()
    {
        Build.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Casser.GetComponent<Image>().color = Color.white;
        Jeter.GetComponent<Image>().color = Color.white;
        Activate.GetComponent<Image>().color = Color.white;
        Die.GetComponent<Image>().color = Color.white;
        Push.GetComponent<Image>().color = Color.white;
        Block.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Climb.GetComponent<Image>().color = Color.white;
        Miner.GetComponent<Image>().color = Color.red;
        variables.btnMinerClicked = true;
        variables.btnClimbClicked = false;
        variables.btnBlockClicked = false;
        variables.btnPushClicked = false;
        variables.btnDieClicked = false;
        variables.btnActivateClicked = false;
        variables.btnJeterClicked = false;
        variables.btnCasserClicked = false;
        variables.btnBuildClicked = false;
        variables.btnCreuserClicked = false;
    }

    void CreuserClicked()
    {
        Build.GetComponent<Image>().color = Color.white;
        Miner.GetComponent<Image>().color = Color.white;
        Casser.GetComponent<Image>().color = Color.white;
        Jeter.GetComponent<Image>().color = Color.white;
        Activate.GetComponent<Image>().color = Color.white;
        Die.GetComponent<Image>().color = Color.white;
        Push.GetComponent<Image>().color = Color.white;
        Block.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.white;
        Climb.GetComponent<Image>().color = Color.white;
        Creuser.GetComponent<Image>().color = Color.red;
        variables.btnCreuserClicked = true;
        variables.btnClimbClicked = false;
        variables.btnBlockClicked = false;
        variables.btnPushClicked = false;
        variables.btnDieClicked = false;
        variables.btnActivateClicked = false;
        variables.btnJeterClicked = false;
        variables.btnCasserClicked = false;
        variables.btnBuildClicked = false;
        variables.btnMinerClicked = false;
    }


<<<<<<< HEAD
    
=======

>>>>>>> refs/remotes/origin/Guillaume
=======
        btnClimbClicked = false;
        btnBlockClicked = false;
        btnPushClicked = false;
        btnDieClicked = false;
        btnActivateClicked = true;
    }
>>>>>>> refs/remotes/origin/Vincent_LAURENT
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
