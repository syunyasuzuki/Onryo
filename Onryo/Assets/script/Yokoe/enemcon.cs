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
        Transform myTransform = transform;

        Vector3 pos = transform.position;
        //float x = Mathf.Sin(Time.time) * 10.0f;
        //transform.position = new Vector3(x, pos.y, pos.z);
       
        while(true)
        {
            if (pos.x == 422f)
            {
                pos.x += 0.1f;
                myTransform.position = pos;  // 座標を設定;
            }
            else if (pos.x == 432f)
            {
                pos.x -= 0.1f;
                myTransform.position = pos;  // 座標を設定
            }
            break;
        }
        

       

    }
}
