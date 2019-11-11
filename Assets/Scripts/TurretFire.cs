using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurretFire : MonoBehaviour
{
    // Start is called before the first frame update
    public float delay = 2f;

    float countdown;
    bool hasFinished=false;
    

    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown<= 0f && !hasFinished)
        {
            Destroy(gameObject);
        }
    }
}
