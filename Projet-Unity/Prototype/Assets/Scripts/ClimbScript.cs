using UnityEngine;
using System.Collections;

public class ClimbScript : MonoBehaviour {

    private Rigidbody2D rig;
<<<<<<< HEAD

=======
    [HideInInspector]public bool sens;
    [HideInInspector]public float hauteur;
>>>>>>> refs/remotes/origin/Guillaume

    private void Awake()
    {
        rig = this.GetComponent<Rigidbody2D>();
<<<<<<< HEAD
=======
        sens = false;
>>>>>>> refs/remotes/origin/Guillaume
    }


    private void FixedUpdate()
    {
<<<<<<< HEAD
        if (this.GetComponent<MouvementScript>().sens && this.GetComponent<BoxCollider2D>().bounds.min.y <= this.GetComponent<MouvementScript>().hauteur)
=======
        if (sens && this.GetComponent<BoxCollider2D>().bounds.min.y <= hauteur)
>>>>>>> refs/remotes/origin/Guillaume
        {

            rig.velocity = new Vector2(rig.velocity.x * Time.deltaTime, rig.velocity.y + Mathf.Abs(this.GetComponent<MouvementScript>().speed / 10));
        }
<<<<<<< HEAD

=======
        else
        {
            rig.velocity = new Vector2(rig.velocity.x * Time.deltaTime + this.GetComponent<MouvementScript>().speed, rig.velocity.y);
        }
>>>>>>> refs/remotes/origin/Guillaume
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.GetComponent<Actions>().isClimber)
        {
            if (collision.contacts[0].normal == new Vector2(-1, 0) || collision.contacts[0].normal == new Vector2(1, 0))
            {
<<<<<<< HEAD
                this.GetComponent<MouvementScript>().sens = true;
                this.GetComponent<MouvementScript>().hauteur = collision.gameObject.GetComponent<BoxCollider2D>().bounds.max.y;
=======
                sens = true;
                hauteur = collision.gameObject.GetComponent<BoxCollider2D>().bounds.max.y;
>>>>>>> refs/remotes/origin/Guillaume
                if (this.GetComponent<MouvementScript>().direction == true) this.GetComponent<MouvementScript>().direction = false;
                else this.GetComponent<MouvementScript>().direction = true;
            }
        }
<<<<<<< HEAD
        if (this.GetComponent<BoxCollider2D>().bounds.min.y >= this.GetComponent<MouvementScript>().hauteur)
        {
            this.GetComponent<Actions>().isClimber = false;
            this.GetComponent<MouvementScript>().sens = false;
=======
        if (this.GetComponent<BoxCollider2D>().bounds.min.y >= hauteur)
        {
            Debug.LogWarning("aCSh");
            this.GetComponent<Actions>().isClimber = false;
            sens = false;
>>>>>>> refs/remotes/origin/Guillaume
        }
    }
}
