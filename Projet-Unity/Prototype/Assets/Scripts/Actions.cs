using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Actions : MonoBehaviour
{
    private Rigidbody2D rig;


    public GameObject randomSong;


    public GameObject score;

    public Button Climb;
    public Button Block;
    public Button Push;
    public Button Die;
    public Button Activate;
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

        rig = this.GetComponent<Rigidbody2D>();

        isBlock = false;
        isClimber = false;
        isPusher = false;
        isActivated = false;
        isJeter = false;
        isCasser = false;
        isBuild = false;
        isMiner = false;
        isCreuser = false;

        Button btnClimb = Climb.GetComponent<Button>();
        Button btnBlock = Block.GetComponent<Button>();
        Button btnPush = Push.GetComponent<Button>();
        Button btnDie = Die.GetComponent<Button>();
        Button btnActivate = Activate.GetComponent<Button>();
        Button btnJeter = Jeter.GetComponent<Button>();
        Button btnCasser = Casser.GetComponent<Button>();
        Button btnBuild = Build.GetComponent<Button>();
        Button btnMiner = Miner.GetComponent<Button>();
        Button btnCreuser = Creuser.GetComponent<Button>();

        btnClimb.onClick.AddListener(ClimbClicked);
        btnBlock.onClick.AddListener(BlockClicked);
        btnPush.onClick.AddListener(PushClicked);
        btnDie.onClick.AddListener(DieClicked);
        btnActivate.onClick.AddListener(ActivateClicked);
        btnJeter.onClick.AddListener(JeterClicked);
        btnCasser.onClick.AddListener(CasserClicked);
        btnBuild.onClick.AddListener(BuildClicked);
        btnMiner.onClick.AddListener(MinerClicked);
        btnCreuser.onClick.AddListener(CreuserClicked);
    }

    void OnMouseDown()
    {
        if (!isBlock)
        {
            if (!isJeter)
            {

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
            new WaitForSecondsRealtime(2);
            Destroy(gameObject);

        }
    }

    void ClimbClicked()
    {
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

    }

    void BlockClicked()
    {
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
    }

    void PushClicked()
    {
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

    }

    void DieClicked()
    {
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
    }

    void ActivateClicked()
    {
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
