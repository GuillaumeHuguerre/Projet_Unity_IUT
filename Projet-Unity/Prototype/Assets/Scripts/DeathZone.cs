using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathZone : MonoBehaviour {

    public GameObject score;
    Animator _anim;

    void Start()
    {
        _anim = this.GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _anim.SetBool("isDead", true);
            Destroy(other.gameObject);
            score.SendMessage("Death");
        }
    }
}
