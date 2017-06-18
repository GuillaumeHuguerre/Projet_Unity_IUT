using UnityEngine;
using System.Collections;



public class MouvementScript : MonoBehaviour
{

   public float speed;
    private Rigidbody2D rig;
   public bool direction;
    [HideInInspector]public bool sens;
    [HideInInspector]public float hauteur;


    private void Awake()
    {
        speed = 2.0f;
        rig = this.GetComponent<Rigidbody2D>();
        direction = true;
    }

    private void Start()
    {
        rig.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
        if (direction == false) speed = -speed;

        
        rig.velocity = new Vector2(rig.velocity.x * Time.deltaTime + this.GetComponent<MouvementScript>().speed, rig.velocity.y);


    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (speed >= 2f )
        {

            speed = 2f;
        }

        if (!this.GetComponent<Actions>().isPusher && !this.GetComponent<Actions>().isBlock)
        {
            if (collision.contacts[0].normal == new Vector2(-1, 0) || collision.contacts[0].normal == new Vector2(1, 0))
            {
                if (direction == true) direction = false;
               else direction = true;
            }
        }
    }

}
