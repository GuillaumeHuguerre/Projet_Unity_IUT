using UnityEngine;
using System.Collections;

public class DiggerController : MonoBehaviour {

	private Rigidbody2D rb;

    private Transform transLemming;

	public CircleCollider2D destructionZone;
	public static GroundController groundController;

    public bool isDigger;
    public bool isMiner;
    private bool digStart;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        transLemming = GetComponent<Transform>();
        isDigger=false;
        isMiner = false;
        digStart = true;
    }

    void Update()
    {
        //creuser
        if (isDigger == true && digStart == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            groundController.DestroyGround(destructionZone);
        }
    }

    
    void OnCollisionEnter2D(Collision2D coll)
    {
        //miner
        if (isMiner == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
            groundController.DestroyGround(destructionZone);
        }
            

        if (coll.collider.tag == "Ground" && isDigger == true)
        {
            digStart = false;
            groundController.DestroyGround(destructionZone);
        }
            
    }

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ColliderEnd")
        {
            isDigger = false;
            digStart = true;
            isMiner = false;
            rb.constraints &= ~rb.constraints | RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
