using UnityEngine;
using System.Collections;



public class MouvementScript : MonoBehaviour
{

    [HideInInspector]public float speed;
    private Rigidbody2D rig;
    [HideInInspector]public bool direction;

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
        if (direction == true) speed = 2.0f;
        else speed = -2.0f;
    }






}
