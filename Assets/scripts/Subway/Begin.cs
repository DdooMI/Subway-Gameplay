using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Begin : MonoBehaviour
{
    public GameObject _3text;
    public GameObject _2text;
    public GameObject _1text;
    public GameObject GOtext;
    public GameObject IntroImage;
    public AudioSource Go;
    public AudioSource Ready;

    private void Start()
    {
        StartCoroutine(CountDown());
    }


    IEnumerator CountDown()
    {
        IntroImage.SetActive(true);
        yield return new WaitForSeconds(1.25f);
        _3text.SetActive(true);
        Ready.Play();
        yield return new WaitForSeconds(0.9f);
        _2text.SetActive(true);
        Ready.Play();
        yield return new WaitForSeconds(0.9f);
        _1text.SetActive(true);
        Ready.Play();
        yield return new WaitForSeconds(0.9f);
        GOtext.SetActive(true);
        Go.Play();
    }

}
