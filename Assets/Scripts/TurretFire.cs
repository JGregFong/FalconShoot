﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurretFire : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Emitter;
    void Start()
    {
        Emitter = GameObject.Find("TurretOutput");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Blaster Bolt

        }
    }
}
