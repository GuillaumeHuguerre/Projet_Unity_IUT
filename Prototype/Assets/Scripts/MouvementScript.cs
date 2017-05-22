using UnityEngine;
using System.Collections;



public class MouvementScript : MonoBehaviour {

    private float speed;
    private Rigidbody2D rig;
    private bool direction;

    private void Awake()
    {
        speed = 1f;
        rig = this.GetComponent<Rigidbody2D>();
        direction = true;
    }

    private void Start()
    {
        rig.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
        if (direction == true) speed = 2.0f;
        else speed = -2.0f;
        rig.velocity =new Vector2 (rig.velocity.x* Time.deltaTime + speed, rig.velocity.y) ;
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
        {
            if (collision.contacts[0].normal == new Vector2(-1, 0) || collision.contacts[0].normal == new Vector2(1, 0))
            {
                if (direction == true) direction = false;
                else direction = true;
            }
        }
    }




}
