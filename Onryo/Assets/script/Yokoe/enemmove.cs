using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemmove : MonoBehaviour
{

    public float speed = 4f;  //移動速度
    public float rotationspeed = 1f;　//向きを変える速度
    public float posrange = 10.0f;
    private Vector3 targetpos;
    private float changetarget = 50f;
    public float targetdistance;

    public AudioClip Ghost_SE;

    static public AudioSource audio;

    Vector3 GetRandomPosition(Vector3 currentpos)
    {
        return new Vector3(Random.Range(-posrange + currentpos.x, posrange + currentpos.x),
            1, Random.Range(-posrange + currentpos.z, posrange + currentpos.z));

        //return new Vector3(10, 0, 10);
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
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = Ghost_SE; //audioにGhost_SEをセット
        
        targetpos = GetRandomPosition(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        targetdistance = Vector3.SqrMagnitude(transform.position - targetpos);
        haikai();

        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("Metamorphose", 3);
        }
    }

    void Metamorphose()
    {
        GetComponent<enemmove>().enabled = false;
        GetComponent<Onryocon>().enabled = true;
    }

}


