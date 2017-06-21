using UnityEngine;
using System.Collections;

public class ClimbScript : MonoBehaviour {

    private Rigidbody2D rig;


    private void Awake()
    {
        rig = this.GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        if (this.GetComponent<MouvementScript>().sens && this.GetComponent<BoxCollider2D>().bounds.min.y <= this.GetComponent<MouvementScript>().hauteur)
        {

            rig.velocity = new Vector2(rig.velocity.x * Time.deltaTime, rig.velocity.y + Mathf.Abs(this.GetComponent<MouvementScript>().speed / 10));
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.GetComponent<Actions>().isClimber)
        {
            if (collision.contacts[0].normal == new Vector2(-1, 0) || collision.contacts[0].normal == new Vector2(1, 0))
            {
                this.GetComponent<MouvementScript>().sens = true;
                this.GetComponent<MouvementScript>().hauteur = collision.gameObject.GetComponent<BoxCollider2D>().bounds.max.y;
                if (this.GetComponent<MouvementScript>().direction == true) this.GetComponent<MouvementScript>().direction = false;
                else this.GetComponent<MouvementScript>().direction = true;
            }
        }
        if (this.GetComponent<BoxCollider2D>().bounds.min.y >= this.GetComponent<MouvementScript>().hauteur)
        {
            this.GetComponent<Actions>().isClimber = false;
            this.GetComponent<MouvementScript>().sens = false;
        }
    }
}
