using UnityEngine;
using System.Collections;

public class ConstruireScript : MonoBehaviour {

    public GameObject objetdroite;
    public GameObject objetgauche;
    private Rigidbody2D rig;
    Animator _anim;

    private void Start()
    {
        _anim = this.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        rig = this.GetComponent<Rigidbody2D>();
        if (this.GetComponent<Actions>().isBuild)
        {
            this.GetComponent<Actions>().isBuild = false;
            StartCoroutine(Construire());
        }
    }
  


        IEnumerator Construire()
    {
        
        int i = 3;

        while (i > 0)
        {
            float minX = this.GetComponent<BoxCollider2D>().bounds.min.x;
            float maxX = this.GetComponent<BoxCollider2D>().bounds.max.x;
            float minY = this.GetComponent<BoxCollider2D>().bounds.min.y - 0.1f;
            if (this.GetComponent<MouvementScript>().speed > 0)
            {
                rig.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
                Instantiate(objetdroite, new Vector2(maxX, minY), Quaternion.identity);
            }
            else
            {
                rig.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
                Instantiate(objetgauche, new Vector2(minX, minY), Quaternion.identity);
            }

            rig.constraints = RigidbodyConstraints2D.FreezeRotation;
            this.GetComponent<MouvementScript>().speed = 1f;
            yield return new WaitForSeconds(1.2f);
            i--;
            if (i==0)
            {
                _anim.SetBool("isBuilder", false);
            }
        }

    }
}
