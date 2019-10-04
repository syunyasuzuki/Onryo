using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCon : MonoBehaviour {

    public float speed;//移動速度
    public GameObject Player;
    public float roatspeed = 2;//回転速度
    bool flag = false;// 左Shiftが押されているかどうかの判定用

    int audio_Con;
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
            transform.position += transform.forward * speed *Time.deltaTime;
        }

        //左クリックを押したら霊聴を使用
        if (Input.GetMouseButtonDown(1) && !flag)
        {
            audio_Con++;
            speed = 0.0f;
            if (audio_Con >= 1)
            {
                FadeCon.isFade1 = true;
                FadeCon.isFadeOut1 = true;
                Onryocon.audio.Play();
                enemmove.audio.Play();
                flag = true;
            }
        }
        else  //霊聴を止める
        {
            if (Input.GetMouseButtonDown(1) && flag)
            {
                audio_Con = 0;
                speed = 7.8f;
                if (audio_Con == 0)
                {
                    FadeCon.isFade1 = true;
                    FadeCon.isFadeIn1 = true;
                    Onryocon.audio.Stop();
                    enemmove.audio.Stop();
                    flag = false;
                }
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Goal")
        {
            SceneManager.LoadScene("GameClearScene");
        }
    }
}
