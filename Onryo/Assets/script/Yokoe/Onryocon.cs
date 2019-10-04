﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onryocon : MonoBehaviour {

    private float speed = 4f;
    public float rotationspeed = 1f;
    public float posrange = 10.0f;
    private Vector3 targetpos;
    private float changetarget = 50f;
    public float targetdistance;

    public Transform target; //追いかける対象
    public Rigidbody rb;

    private Vector3 vec;

    public AudioClip Onryo_SE;

    AudioSource audio;

    Vector3 GetRandomPosition(Vector3 currentpos)
    {
        return new Vector3(Random.Range(-posrange + currentpos.x, posrange + currentpos.x),
            0, Random.Range(-posrange + currentpos.z, posrange + currentpos.z));
    }

    void haikai()
    {
        if (targetdistance < changetarget) targetpos =
                    GetRandomPosition(transform.position);

        Quaternion targetRotation =
            Quaternion.LookRotation(targetpos - transform.position);
        transform.rotation =
            Quaternion.Slerp(transform.rotation, targetRotation,
            Time.deltaTime * rotationspeed);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //Debug.Log("haikai");
    }

    // Use this for initialization
    void Start ()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = Onryo_SE; //audioにOnryo_SEをセット
        audio.Play();
        targetpos = GetRandomPosition(transform.position);
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        targetdistance = Vector3.SqrMagnitude(transform.position - targetpos);
        haikai();

        //座標取得
        Vector3 tmp = GameObject.Find("Onryo").transform.position;
        GameObject.Find("Onryo").transform.position = new Vector3(tmp.x, tmp.y, tmp.z);
        float x = tmp.x;
        float y = tmp.y;
        float z = tmp.z;

        //プレイヤ座標取得
        Vector3 tmp2 = GameObject.Find("Player").transform.position;
        GameObject.Find("Player").transform.position = new Vector3(tmp2.x, tmp2.y, tmp2.z);
        float x2 = tmp2.x;
        float y2 = tmp2.y;
        float z2 = tmp2.z;

        if (tmp2.x - tmp.x <= 5 && tmp2.x - tmp.x >= -5 && tmp2.z - tmp.z >= 5 && tmp2.z - tmp.z >= -5) 
        {
            //targetの向きに少しずつ向きが変わる
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);

            speed = 6f;

            //targetに向かって進む
            transform.position += transform.forward * speed * Time.deltaTime;
            //rb.AddForce(a * speed, 0, b * speed);

        }
        else
        {
            speed = 4f;
            targetdistance = Vector3.SqrMagnitude(transform.position - targetpos);
            haikai();
        }

        
    }
}
