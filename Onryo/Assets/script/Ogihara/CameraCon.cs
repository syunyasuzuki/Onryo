﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour {

    public GameObject Player;
    public GameObject Camera;
    private Transform PlayerTransform;
    private Transform CameraTransform;
    float X_Rotation;
    float Y_Rotation;

    // Use this for initialization
    void Start()
    {

        PlayerTransform = transform.parent;
        CameraTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        X_Rotation = Input.GetAxis("Mouse X");
        Y_Rotation = Input.GetAxis("Mouse Y");
        PlayerTransform.transform.Rotate(0, X_Rotation, 0);
        //CameraTransform.transform.Rotate(-Y_Rotation, 0, 0);

        float angleDir = PlayerTransform.transform.eulerAngles.y * (Mathf.PI / 180.0f);
        Vector3 dir1 = new Vector3(Mathf.Sin(angleDir), 0, Mathf.Cos(angleDir));
        //Vector3 dir2 = new Vector3(-Mathf.Cos(angleDir), 0, Mathf.Sin(angleDir));


    }
}

