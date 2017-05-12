using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject lemming;
    public float Temps;
    private int nbrLemming;

    // Use this for initialization
    void Start () {
        InvokeRepeating("CreateNewObstacle", 2.0f, 1.0f);
        Temps = constantes.TEMPS;
        nbrLemming = constantes.NBRLEMMINGS;
    }

    // Update is called once per frame
    void CreateNewObstacle()
    {
        if (nbrLemming != 0)
        {
            Instantiate(lemming, new Vector3(-5f, 0f, 0f), Quaternion.identity);
            --nbrLemming;
        }
    }
}
