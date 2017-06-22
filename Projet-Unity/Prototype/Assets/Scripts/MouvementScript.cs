using UnityEngine;
using System.Collections;



public class MouvementScript : MonoBehaviour
{
    bool first = true;
    public float speed;
    private Rigidbody2D rig;
    public bool direction;
    [HideInInspector]public bool sens;
    [HideInInspector]public float hauteur;
    GameObject pos;
    SpriteRenderer sr;


    private void Awake()
    {
        speed = 0.0f;
        rig = this.GetComponent<Rigidbody2D>();
        sr = this.GetComponent<SpriteRenderer>();
        direction = true;
    }

    private void Start()
    {
        rig.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {


        if (direction == false)
        {
            speed = -speed;
            direction = true;
        }
            

        
        rig.velocity = new Vector2(rig.velocity.x * Time.deltaTime + this.GetComponent<MouvementScript>().speed, rig.velocity.y);


    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (first == true)
        {
            speed = 0.8f;
            first = false;
        }

        if (speed >= 0.8f )
        {

            speed = 0.8f;
        }
        
        if (!this.GetComponent<Actions>().isPusher && !this.GetComponent<Actions>().isBlock)
        {

            //if (collision.contacts[0].normal == new Vector2(-1, 0) || collision.contacts[0].normal == new Vector2(1, 0))
            if (collision.gameObject.tag== "Mur")
            {
                if (direction == true)
                {
                    sr.flipX = (speed < 0);
                    direction = false;
                }
                else
                {
                    sr.flipX = (speed > 0);
                    direction = true;
                }
            }
        }
    
    }
}
