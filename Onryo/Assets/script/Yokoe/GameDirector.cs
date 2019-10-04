using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    public Image Manual;

    float alpha;

    bool manual_check;

    int z = 0;
	// Use this for initialization
	void Start ()
    {
        manual_check = false;
        alpha = 0;
        Manual.color = new Color(1.0f, 1.0f, 1.0f, alpha);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!manual_check)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                z++;

                if (z >= 1)
                {
                    alpha = 1.0f;
                    Manual.color = new Color(1.0f, 1.0f, 1.0f, alpha);
                    manual_check = true;
                }

            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                z = 0;

                if(z==0)
                {
                    alpha = 0.0f;
                    Manual.color = new Color(1.0f, 1.0f, 1.0f, alpha);
                    manual_check = false;
                }
                
            }
        }
        

       
    }
}
