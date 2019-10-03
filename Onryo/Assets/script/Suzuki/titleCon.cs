using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleCon : MonoBehaviour
{
    AudioSource audio;
    public AudioClip Start_SE;

	// Use this for initialization
	void Start ()
    {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            FadeCon.isFade1 = true;
            FadeCon.isFadeOut1 = true;
            audio.PlayOneShot(Start_SE);
            audio.Stop();
            Invoke("Scene", 3.0f);
        }
	}

    void Scene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
