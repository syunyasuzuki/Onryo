using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour {

    public float speed = 3f;//移動速度
    public GameObject Player;
    public float roatspeed = 2;//回転速度
    bool flag = false;// 左Shiftが押されているかどうかの判定用
    void Start()
    {

    }

    void Update()
    {
        if (flag == false)
        {
            float angle = Input.GetAxis("Horizontal") * roatspeed;
            Vector3 playerpos = Player.transform.position;
            transform.RotateAround(playerpos, Vector3.up, angle);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey("up"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0;
            flag = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 4;
            flag = false;
        }
    }
}
