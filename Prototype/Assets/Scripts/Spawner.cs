using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject lemming;
    private GameObject _spawnedObj;
    public float Temps;
    private int nbrLemming;

    // Use this for initialization
    void Start () {
        Temps = constantes.TEMPS;
        InvokeRepeating("CreateNewLemming", Temps, 1.0f);       
        nbrLemming = constantes.NBRLEMMINGS;

    }

    // Update is called once per frame
    private void CreateNewLemming()
    {
        if (nbrLemming != 0)
        {
            Instantiate(lemming, new Vector3(-5f, 0f, 0f), Quaternion.identity);
            
            --nbrLemming;
        }
    }
}
