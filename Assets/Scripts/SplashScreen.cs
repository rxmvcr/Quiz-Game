using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    public GameObject splashText;
    public GameObject splashImage;
    public GameObject bgm;

    void Start()
    {
        StartCoroutine(SplashEnd());
    }

    IEnumerator SplashEnd()
    {
        yield return new WaitForSeconds(4);
        bgm.SetActive(true);
        splashText.SetActive(false);
        splashImage.SetActive(false);
    }
}
