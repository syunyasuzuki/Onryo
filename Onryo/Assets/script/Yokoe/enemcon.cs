using System.Collections;
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

        // 三角関数を用いてX軸方向に揺らす
        Vector3 pos = transform.position;
        float x = Mathf.Sin(Time.time) * 10.0f;
        transform.position = new Vector3(x + start_Pos/*x+ pos.x*/, pos.y, pos.z);

    }
}
