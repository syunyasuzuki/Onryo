using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleCon : MonoBehaviour
{
    public AudioClip Start_SE;
    public AudioClip title_BGM;
    AudioSource audio;

    int sound_count = 0;

	// Use this for initialization
	void Start ()
    {
        audio = gameObject.GetComponent<AudioSource>();
        audio.clip = title_BGM;
        audio.Play();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            sound_count++;
            FadeCon.isFade1 = true;
            FadeCon.isFadeOut1 = true;
            if (sound_count <= 1)
            {
                audio.clip = Start_SE;
                audio.Play();
            }
            Invoke("Scene", 4.0f);
        }
	}

    void Scene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
