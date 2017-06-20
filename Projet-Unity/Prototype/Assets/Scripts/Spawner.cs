using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject lemming;
<<<<<<< HEAD
    private BoxCollider2D _spawnedObj;
    public float Temps;
    private int nbrLemming;
    private float Cx;
    private float Cy;

    // Use this for initialization
    void Start () {
        _spawnedObj = gameObject.GetComponent<BoxCollider2D>();
        Cx = _spawnedObj.bounds.center.x;
        Cy = _spawnedObj.bounds.center.y;
=======
    private GameObject _spawnedObj;
    public float Temps;
    private int nbrLemming;

    // Use this for initialization
    void Start () {
>>>>>>> refs/remotes/origin/Vincent_LAURENT
        Temps = constantes.TEMPS;
        InvokeRepeating("CreateNewLemming", Temps, 1.0f);       
        nbrLemming = constantes.NBRLEMMINGS;

    }

    // Update is called once per frame
    private void CreateNewLemming()
    {
        if (nbrLemming != 0)
        {
<<<<<<< HEAD
            Instantiate(lemming, new Vector2(Cx, Cy), Quaternion.identity);
=======
            Instantiate(lemming, new Vector3(-5f, 0f, 0f), Quaternion.identity);
            
>>>>>>> refs/remotes/origin/Vincent_LAURENT
            --nbrLemming;
        }
    }
}
