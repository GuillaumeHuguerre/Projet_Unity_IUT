using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{

    Rigidbody2D rig;
    private float speed;
    private SpriteRenderer p_sr;
    Animator _anim;
    bool direction = false;


    void Awake()
    {
        rig = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            if (direction == true) direction = false;
            else direction = true;
        }
    }

    private void FixedUpdate()
    {
        if (direction == false)   rig.velocity = new Vector2(2f, rig.velocity.y);
        else rig.velocity = new Vector2(-2f, rig.velocity.y);
    }


}