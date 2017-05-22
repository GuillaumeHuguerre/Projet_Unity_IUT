using UnityEngine;
using System.Collections;

public class Open : MonoBehaviour
{
    Vector3 target = new Vector3(14, 3, 0);
    public float openSpeed;

    // Use this for initialization
    void Start()
    {
        variables.doorIsActivated = false;
        openSpeed = constantes.OPENSPEED;

    }

    // Update is called once per frame
    void Update()
    {
        if (variables.doorIsActivated)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, openSpeed * Time.deltaTime);
        }

    }
}
