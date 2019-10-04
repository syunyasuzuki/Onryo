using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Invoke("Go_Title", 2.0f);
        }    
    }

    void Go_Title()
    {
        SceneManager.LoadScene("TitleScene");
    }

}
