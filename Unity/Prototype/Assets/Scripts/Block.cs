using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (constantes.block)
        {
            gameObject.layer = 8;
            //mettre la vitesse à 0
        }
	
	}
}
