﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiger : MonoBehaviour {
    Animation an;
    // Use this for initialization
    void Start () {
        an = GetComponent<Animation>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * 0.1f;
        an.Play("Walk");
    }
}
