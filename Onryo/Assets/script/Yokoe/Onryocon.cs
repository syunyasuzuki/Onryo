using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Onryocon : MonoBehaviour
{

    private float speed = 8f;
    public Transform target; //追いかける対象
    private Vector3 vec;

    public Rigidbody rb;

    public AudioClip Onryo_SE;

    static public AudioSource audio;

    public static bool ou_set;


    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = Onryo_SE; //audioにOnryo_SEをセット
        rb = GetComponent<Rigidbody>();

        ou_set = false;
    }

    // Update is called once per frame
    void Update()
    {
        audio.Play();
        if (ou_set)
        {
            //targetの方に少しずつ向きが変わる
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);

            //targetに向かって進む
            transform.position += transform.forward * Time.deltaTime * speed;
            Debug.Log("追う");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ou_set = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        ou_set = false;
    }



    //void Reload()
    //{
    //    SceneManager.LoadScene("GameScene");
    //}
}
