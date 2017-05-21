using UnityEngine;
using System.Collections;



public class MouvementScript : MonoBehaviour {

    private float speed;
    private Rigidbody2D rig;
    private bool direction;

    private void Awake()
    {
        speed = 1f;
        rig = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
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
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (direction == true) direction = false;
            else direction = true;
        }
    }
}
