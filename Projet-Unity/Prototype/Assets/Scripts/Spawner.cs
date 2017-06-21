using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject lemming;
    private BoxCollider2D _spawnedObj;
    public float Temps;
    private int nbrLemming;
    private float Cx;
    private float Cy;

    public GameObject score;

    public Button Climb;
    public Button Block;
    public Button Push;
    public Button Die;
    public Button Activate;
    public Button Jeter;
    public Button Casser;
    public Button Build;
    public Button Miner;
    public Button Creuser;

    // Use this for initialization
    void Start () {
        _spawnedObj = gameObject.GetComponent<BoxCollider2D>();
        Cx = _spawnedObj.bounds.center.x;
        Cy = _spawnedObj.bounds.center.y;
        Temps = constantes.TEMPS;
        InvokeRepeating("CreateNewLemming", Temps, 3.0f);       
        nbrLemming = constantes.NBRLEMMINGS;

    }

    // Update is called once per frame
    private void CreateNewLemming()
    {
        if (nbrLemming != 0)
        {
            GameObject obj = Instantiate(lemming, new Vector2(Cx, Cy), Quaternion.identity) as GameObject;

            Actions a = obj.GetComponent<Actions>();
            a.Block = Block;
            a.Climb = Climb;
            a.Push = Push;
            a.Die = Die;
            a.Activate = Activate;
            a.Jeter = Jeter;
            a.Casser = Casser;
            a.Build = Build;
            a.Miner = Miner;
            a.Creuser = Creuser;
            a.score = score;

            --nbrLemming;
        }
    }
}
