﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemcon : MonoBehaviour
{
    public float start_Pos;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Transform myTransform = transform;

        Vector3 pos = transform.position;
        float x = Mathf.Sin(Time.time) * 10.0f;
        transform.position = new Vector3(x+ start_Pos, pos.y, pos.z);

    }
}
