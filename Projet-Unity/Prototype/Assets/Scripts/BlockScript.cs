using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {

    private Rigidbody2D rig;

    private void Awake()
    {
        rig = this.GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if (this.GetComponent<Actions>().isBlock)
        {
            gameObject.layer = 8;
            gameObject.tag = "Mur";
            rig.constraints = rig.constraints | RigidbodyConstraints2D.FreezePositionX;
        }


    }

}
