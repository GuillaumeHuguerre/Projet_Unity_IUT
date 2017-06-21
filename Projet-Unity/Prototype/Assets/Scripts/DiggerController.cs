using UnityEngine;
using System.Collections;

public class DiggerController : MonoBehaviour {

	private Rigidbody2D rb;

    private Transform transLemming;

	public CircleCollider2D destructionZone;
	public static GroundController groundController;
    Animator _anim;

   
    private bool digStart;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        transLemming = GetComponent<Transform>();
        _anim = this.GetComponent<Animator>();
       
        digStart = true;
    }

    void Update()
    {
        //creuser
        if (this.GetComponent<Actions>().isCreuser == true && digStart == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            groundController.DestroyGround(destructionZone);
        }
    }

    
    void OnCollisionEnter2D(Collision2D coll)
    {
        //miner
        if (coll.collider.tag == "Ground" && this.GetComponent<Actions>().isMiner == true)
        {
           
            rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
            groundController.DestroyGround(destructionZone);
        }
            

        if (coll.collider.tag == "Ground" && this.GetComponent<Actions>().isCreuser == true)
        {
            digStart = false;
            groundController.DestroyGround(destructionZone);
        }
            
    }

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ColliderEnd")
        {
            _anim.SetBool("isDigger", false);
            _anim.SetBool("isMiner", false);
            this.GetComponent<Actions>().isCreuser = false;
            digStart = true;
            this.GetComponent<Actions>().isMiner = false;
            rb.constraints &= ~rb.constraints | RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
