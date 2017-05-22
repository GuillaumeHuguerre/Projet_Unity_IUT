using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{

    public float MAX_SPEED;
    public float acceleration;
    private float speed;
    private SpriteRenderer p_sr;
    Animator _anim;

    private bool pousseeEnCours;
    private bool pousseInverse=false;

    void Awake()
    {
        if (MAX_SPEED <= 0) MAX_SPEED = 2;
        if (acceleration <= 0) acceleration = 0.5f;
    }

    void Start()
    {
        speed = constantes.SPEED;

        p_sr = this.GetComponent<SpriteRenderer>();
        _anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed += acceleration;
            if (speed > MAX_SPEED) speed = MAX_SPEED;
            _doMove();
            return;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed -= acceleration;
            if (speed < -MAX_SPEED) speed = -MAX_SPEED;
            _doMove();
            return;
        }

        if (speed != 0)
        {
            // aucune touche presséé : deceleration
            speed = speed + Mathf.Sign(speed) * -acceleration;
            _doMove();
        }
        if (Mathf.Abs(speed) < acceleration)
            // vitesse insignifiante => =0
            speed = 0.0f;
    }

    void _doMove()
    {
        _anim.SetFloat("Speed", Mathf.Abs(speed));
        if (speed != 0f) p_sr.flipX = (speed < 0);
        if (!pousseInverse)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * -speed * Time.deltaTime);
        }
    }
}