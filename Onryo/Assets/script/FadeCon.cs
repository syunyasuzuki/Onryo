using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeCon : MonoBehaviour
{
    public Image FadeImage1;
    public Image FadeImage2;
    public Image FadeImage3;

    public static bool isFade1;
    public static bool isFadeOut1;
    public static bool isFadeIn1;

    public static bool isFade2;
    public static bool isFadeOut2;
    public static bool isFadeIn2;

    public static bool isFade3;
    public static bool isFadeOut3;
    public static bool isFadeIn3;

    public static float alpha1;
    public static float alpha2;
    public static float alpha3;

    // Use this for initialization
    void Start ()
    {
        isFade1 = true;
        isFadeIn1 = true;
        isFadeOut1 = false;

        isFade2 = true;
        isFadeIn2 = true;
        isFadeOut2 = false;

        isFade3 = true;
        isFadeIn3 = true;
        isFadeOut3 = false;

        if (SceneManager.GetActiveScene().name == "ClearScene")
        {
            alpha1 = 0.0f;
            alpha2 = 1.0f;
            alpha3 = 0.0f;
        }
        else if (SceneManager.GetActiveScene().name == "GameOverScene")
        {
            alpha1 = 0.0f;
            alpha2 = 0.0f;
            alpha3 = 1.0f;
        }
        else
        {
            alpha1 = 1.0f;
            alpha2 = 0.0f;
            alpha3 = 0.0f;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (isFade1)
        {
            if (isFadeIn1)
            {
                FadeIn1();
            }
            else if (isFadeOut1)
            {
                FadeOut1();
            }

        }
        if (isFade2)
        {
            if (isFadeIn2)
            {
                FadeIn2();
            }
            else if (isFadeOut2)
            {
                FadeOut2();
            }
        }
        if (isFade3)
        {
            if (isFadeIn3)
            {
                FadeIn3();
            }
            else if (isFadeOut3)
            {
                FadeOut3();
            }
        }
    }

    public void FadeIn1()
    {
        alpha1 -= 0.05f;
        FadeImage1.color = new Color(1.0f, 1.0f, 1.0f, alpha1);
        if (alpha1 <= 0.0f)
        {
            isFadeIn1 = false;
            isFade1 = false;
        }
    }

    public void FadeOut1()
    {
        alpha1 += 0.05f;
        FadeImage1.color = new Color(1.0f, 1.0f, 1.0f, alpha1);
        if (alpha1 >= 1.0f)
        {
            isFadeOut1 = false;
            isFade1 = false;
        }
    }
    public void FadeIn2()
    {
        alpha2 -= 0.05f;
        FadeImage2.color = new Color(1.0f, 1.0f, 1.0f, alpha2);
        if (alpha2 <= 0.0f)
        {
            isFadeIn2 = false;
            isFade2 = false;
        }
    }
    public void FadeOut2()
    {
        alpha2 += 0.02f;
        FadeImage2.color = new Color(1.0f, 1.0f, 1.0f, alpha2);
        if (alpha2 >= 1.0f)
        {
            isFadeOut2 = false;
            isFade2 = false;
            SceneManager.LoadScene("ClearScene");
        }
    }

    public void FadeIn3()
    {
        alpha3 -= 0.05f;
        FadeImage3.color = new Color(1.0f, 1.0f, 1.0f, alpha3);
        if (alpha3 <= 0.0f)
        {
            isFadeIn3 = false;
            isFade3 = false;
        }
    }
    public void FadeOut3()
    {
        alpha3 += 0.05f;
        FadeImage3.color = new Color(1.0f, 1.0f, 1.0f, alpha3);
        if (alpha3 >= 1.0f)
        {
            isFadeOut3 = false;
            isFade3 = false;
        }
    }
}
