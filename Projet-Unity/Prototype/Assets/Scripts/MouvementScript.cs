using UnityEngine;
using System.Collections;



public class MouvementScript : MonoBehaviour
{

<<<<<<< HEAD
<<<<<<< HEAD
   public float speed;
    private Rigidbody2D rig;
   public bool direction;
    [HideInInspector]public bool sens;
    [HideInInspector]public float hauteur;

=======
    [HideInInspector]public float speed;
    private Rigidbody2D rig;
    [HideInInspector]public bool direction;
>>>>>>> refs/remotes/origin/Guillaume

    private void Awake()
    {
        speed = 2.0f;
        rig = this.GetComponent<Rigidbody2D>();
        direction = true;
=======
    private float speed;
    private Rigidbody2D rig;
    [HideInInspector]
    public bool direction;
    private bool sens;
    private float hauteur;

    private void Awake()
    {
        speed = 1f;
        rig = this.GetComponent<Rigidbody2D>();
        direction = true;
        sens = false;
>>>>>>> refs/remotes/origin/Vincent_LAURENT
    }

    private void Start()
    {
        rig.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        if (direction == false) speed = -speed;

        
        rig.velocity = new Vector2(rig.velocity.x * Time.deltaTime + this.GetComponent<MouvementScript>().speed, rig.velocity.y);


=======
        if (direction == true) speed = 2.0f;
        else speed = -2.0f;
>>>>>>> refs/remotes/origin/Guillaume
    }




<<<<<<< HEAD
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (speed >= 2f )
        {

            speed = 2f;
        }

        if (!this.GetComponent<Actions>().isPusher && !this.GetComponent<Actions>().isBlock)
=======
        if (direction == true) speed = 2.0f;
        else speed = -2.0f;
        if (sens && this.GetComponent<BoxCollider2D>().bounds.min.y <= hauteur)
        {
           
            rig.velocity = new Vector2(rig.velocity.x * Time.deltaTime, rig.velocity.y + Mathf.Abs(speed/10));
        }                
        else
            {
                rig.velocity = new Vector2(rig.velocity.x * Time.deltaTime + speed, rig.velocity.y);
            }

        if (this.GetComponent<Actions>().isBlock)
        {

            gameObject.layer = 8;
            rig.constraints = rig.constraints | RigidbodyConstraints2D.FreezePositionX;


        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.GetComponent<Actions>().isPusher)
        {
            if (collision.gameObject.CompareTag("Box")) Debug.LogWarning("Ah");
            else
            {
                if (collision.contacts[0].normal == new Vector2(-1, 0) || collision.contacts[0].normal == new Vector2(1, 0))
                {
                    if (direction == true) direction = false;
                    else direction = true;
                }
            }

        }
        else
>>>>>>> refs/remotes/origin/Vincent_LAURENT
        {
            if (collision.contacts[0].normal == new Vector2(-1, 0) || collision.contacts[0].normal == new Vector2(1, 0))
            {
                if (direction == true) direction = false;
<<<<<<< HEAD
               else direction = true;
            }
        }
    }
=======

>>>>>>> refs/remotes/origin/Guillaume
=======
                else direction = true;
            }
        }
        if (this.GetComponent<Actions>().isClimber)
        {
            if (collision.contacts[0].normal == new Vector2(-1, 0) || collision.contacts[0].normal == new Vector2(1, 0))
            {

                sens = true;
                hauteur = collision.gameObject.GetComponent<BoxCollider2D>().bounds.max.y;
                if (direction == true) direction = false;
                else direction = true;
            }
        }
        if (this.GetComponent<BoxCollider2D>().bounds.min.y >= hauteur)
        {
            Debug.LogWarning("aCSh");
            this.GetComponent<Actions>().isClimber = false;
            sens = false;
        }
    }



>>>>>>> refs/remotes/origin/Vincent_LAURENT

}
