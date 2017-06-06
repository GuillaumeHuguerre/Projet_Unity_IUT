using UnityEngine;
using System.Collections;

public class PushScript : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.GetComponent<Actions>().isPusher)
        {
            if (!collision.gameObject.CompareTag("Box"))
            {
                if (collision.contacts[0].normal == new Vector2(-1, 0) || collision.contacts[0].normal == new Vector2(1, 0))
                {
                    if (this.GetComponent<MouvementScript>().direction == true) this.GetComponent<MouvementScript>().direction = false;
                    else this.GetComponent<MouvementScript>().direction = true;
                }
            }

        }
        else
        {
            if (collision.contacts[0].normal == new Vector2(-1, 0) || collision.contacts[0].normal == new Vector2(1, 0))
            {
                if (this.GetComponent<MouvementScript>().direction == true) this.GetComponent<MouvementScript>().direction = false;
                else this.GetComponent<MouvementScript>().direction = true;
            }
        }
    }
}
