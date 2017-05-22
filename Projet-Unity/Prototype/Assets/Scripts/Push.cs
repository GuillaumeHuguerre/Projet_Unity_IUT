using UnityEngine;
using System.Collections;

public class Push : MonoBehaviour {
    static public Rigidbody2D rig;

    private void Awake()
    {
        rig = this.GetComponent<Rigidbody2D>();
    }
}
