﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Present00 : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Camera")
        {
            Destroy(this.gameObject);

        }
    }
}

