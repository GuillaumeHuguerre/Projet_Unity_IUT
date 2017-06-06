using UnityEngine;
using System.Collections;

public class ClimbScript : MonoBehaviour {

    private Rigidbody2D rig;
    [HideInInspector]public bool sens;
    [HideInInspector]public float hauteur;

    private void Awake()
    {
        rig = this.GetComponent<Rigidbody2D>();
        sens = false;
    }


    private void FixedUpdate()
    {
        if (sens && this.GetComponent<BoxCollider2D>().bounds.min.y <= hauteur)
        {

            rig.velocity = new Vector2(rig.velocity.x * Time.deltaTime, rig.velocity.y + Mathf.Abs(this.GetComponent<MouvementScript>().speed / 10));
        }
        else
        {
            rig.velocity = new Vector2(rig.velocity.x * Time.deltaTime + this.GetComponent<MouvementScript>().speed, rig.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.GetComponent<Actions>().isClimber)
        {
            if (collision.contacts[0].normal == new Vector2(-1, 0) || collision.contacts[0].normal == new Vector2(1, 0))
            {
                sens = true;
                hauteur = collision.gameObject.GetComponent<BoxCollider2D>().bounds.max.y;
                if (this.GetComponent<MouvementScript>().direction == true) this.GetComponent<MouvementScript>().direction = false;
                else this.GetComponent<MouvementScript>().direction = true;
            }
        }
        if (this.GetComponent<BoxCollider2D>().bounds.min.y >= hauteur)
        {
            Debug.LogWarning("aCSh");
            this.GetComponent<Actions>().isClimber = false;
            sens = false;
        }
    }
}
