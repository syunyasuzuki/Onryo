using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Onryocon2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("GameOver", 2.0f);
            //audio.clip = Onryo_SE2;
            //audio.Play();
        }

    }

    void GameOver()
    {
        SceneManager.LoadScene("GameScene");
        //FadeCon.isFade1 = true;
        //FadeCon.isFadeOut1 = true;
        //Invoke("Reload", 2.0f);
    }
}
