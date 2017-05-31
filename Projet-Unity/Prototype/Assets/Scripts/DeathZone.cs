using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathZone : MonoBehaviour {

    public GameObject score;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            score.SendMessage("Death");
        }
    }
}
